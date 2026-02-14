-- Third Highest Total Sales
WITH OrderTotals AS (
    SELECT 
        OrderID,
        SUM(CAST(q.value AS INT) * CAST(p.value AS INT)) AS TotalSales
    FROM Sales_Raw
    CROSS APPLY STRING_SPLIT(Quantities, ',') q
    CROSS APPLY STRING_SPLIT(UnitPrices, ',') p
    GROUP BY OrderID
)
SELECT TotalSales
FROM (
    SELECT TotalSales,
           DENSE_RANK() OVER (ORDER BY TotalSales DESC) AS rnk
    FROM OrderTotals
) t
WHERE rnk = 3;

-- Salespersons with total sales > 60000
SELECT 
    SalesPerson,
    SUM(CAST(q.value AS INT) * CAST(p.value AS INT)) AS TotalSales
FROM Sales_Raw
CROSS APPLY STRING_SPLIT(Quantities, ',') q
CROSS APPLY STRING_SPLIT(UnitPrices, ',') p
GROUP BY SalesPerson
HAVING SUM(CAST(q.value AS INT) * CAST(p.value AS INT)) > 60000;
