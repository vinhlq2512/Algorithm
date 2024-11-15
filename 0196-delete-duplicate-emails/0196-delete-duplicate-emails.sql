;WITH CTE AS (
    SELECT id, email, ROW_NUMBER() OVER (PARTITION BY email ORDER BY id ) AS Rank
    FROM Person
)
DELETE FROM CTE
WHERE Rank  > 1;
