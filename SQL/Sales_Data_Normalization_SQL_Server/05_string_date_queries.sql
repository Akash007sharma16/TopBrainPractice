-- Customers spending more than average
WITH CustomerTotals AS (
    SELECT 
        CustomerName,
        SUM(CAST(q.value AS INT) * CAST(p.value AS INT)) AS TotalSpent
    FROM Sales_Raw
    CROSS APPLY STRING_SPLIT(Quantities, ',') q
    CROSS APPLY STRING_SPLIT(UnitPrices, ',') p
    GROUP BY CustomerName
)
SELECT *
FROM CustomerTotals
WHERE TotalSpent > (SELECT AVG(TotalSpent) FROM CustomerTotals);

-- String & Date Functions
SELECT 
    UPPER(CustomerName) AS CustomerName,
    MONTH(CAST(OrderDate AS DATE)) AS OrderMonth,
    OrderDate
FROM Sales_Raw
WHERE YEAR(CAST(OrderDate AS DATE)) = 2026
  AND MONTH(CAST(OrderDate AS DATE)) = 1;
