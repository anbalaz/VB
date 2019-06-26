Imports System.ComponentModel
Imports System.Linq.Expressions

Public Class SortableBindingList(Of T)
    Inherits BindingList(Of T)

    Private originalList As List(Of T)
    Private sortDirection As ListSortDirection
    Private sortProperty As PropertyDescriptor
    Private populateBaseList As Action(Of SortableBindingList(Of T), List(Of T)) = Sub(a, b) a.ResetItems(b)
    Shared cachedOrderByExpressions As Dictionary(Of String, Func(Of List(Of T), IEnumerable(Of T))) = New Dictionary(Of String, Func(Of List(Of T), IEnumerable(Of T)))()

    Public Sub New()
        originalList = New List(Of T)()
    End Sub

    Public Sub New(ByVal enumerable As IEnumerable(Of T))
        originalList = enumerable.ToList()
        populateBaseList(Me, originalList)
    End Sub

    Public Sub New(ByVal list As List(Of T))
        originalList = list
        populateBaseList(Me, originalList)
    End Sub

    Protected Overrides Sub ApplySortCore(ByVal prop As PropertyDescriptor, ByVal direction As ListSortDirection)
        sortProperty = prop
        Dim orderByMethodName = If(sortDirection = ListSortDirection.Ascending, "OrderBy", "OrderByDescending")
        Dim cacheKey = (GetType(T).GUID).ToString + prop.Name & orderByMethodName

        If Not cachedOrderByExpressions.ContainsKey(cacheKey) Then
            CreateOrderByMethod(prop, orderByMethodName, cacheKey)
        End If

        ResetItems(cachedOrderByExpressions(cacheKey)(originalList).ToList())
        ResetBindings()
        sortDirection = If(sortDirection = ListSortDirection.Ascending, ListSortDirection.Descending, ListSortDirection.Ascending)
    End Sub

    Private Sub CreateOrderByMethod(ByVal prop As PropertyDescriptor, ByVal orderByMethodName As String, ByVal cacheKey As String)
        Dim sourceParameter = Expression.Parameter(GetType(List(Of T)), "source")
        Dim lambdaParameter = Expression.Parameter(GetType(T), "lambdaParameter")
        Dim accesedMember = GetType(T).GetProperty(prop.Name)
        Dim propertySelectorLambda = Expression.Lambda(Expression.MakeMemberAccess(lambdaParameter, accesedMember), lambdaParameter)
        Dim orderByMethod = GetType(Enumerable).GetMethods().Where(Function(a) a.Name = orderByMethodName AndAlso a.GetParameters().Length = 2).Single().MakeGenericMethod(GetType(T), prop.PropertyType)
        Dim orderByExpression = Expression.Lambda(Of Func(Of List(Of T), IEnumerable(Of T)))(Expression.[Call](orderByMethod, New Expression() {sourceParameter, propertySelectorLambda}), sourceParameter)
        cachedOrderByExpressions.Add(cacheKey, orderByExpression.Compile())
    End Sub

    Protected Overrides Sub RemoveSortCore()
        ResetItems(originalList)
    End Sub

    Private Sub ResetItems(ByVal items As List(Of T))
        MyBase.ClearItems()

        For i As Integer = 0 To items.Count - 1
            MyBase.InsertItem(i, items(i))
        Next
    End Sub

    Protected Overrides ReadOnly Property SupportsSortingCore As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides ReadOnly Property SortDirectionCore As ListSortDirection
        Get
            Return sortDirection
        End Get
    End Property

    Protected Overrides ReadOnly Property SortPropertyCore As PropertyDescriptor
        Get
            Return sortProperty
        End Get
    End Property

    Protected Overrides Sub OnListChanged(ByVal e As ListChangedEventArgs)
        originalList = MyBase.Items.ToList()
    End Sub
End Class
