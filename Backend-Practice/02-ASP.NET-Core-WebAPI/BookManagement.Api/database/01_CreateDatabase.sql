IF DB_ID(N'BookManagement') IS NULL
BEGIN
    CREATE DATABASE BookManagement;
END;
GO

SELECT name
FROM sys.databases
WHERE name = N'BookManagement';
GO