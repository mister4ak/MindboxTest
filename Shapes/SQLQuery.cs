namespace Shapes;

public class SQLQuery
{
    // Предполагается, что есть таблица ProductCategory для связи продуктов и категорий
    public string GetQuery()
    {
        return @"
                SELECT P.ProductName, C.CategoryName
                FROM Products P
                LEFT JOIN ProductCategory PC ON P.ProductID = PC.ProductID
                LEFT JOIN Categories C ON PC.CategoryID = C.CategoryID";
        
    }
}