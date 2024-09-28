IF OBJECT_ID(N'employees', N'U') IS NULL
    CREATE TABLE employees (
        EmployeeID INT PRIMARY KEY NOT NULL IDENTITY(0,1),
        FirstName VARCHAR(255) NOT NULL,
        LastName VARCHAR(255) NOT NULL,
        Gender VARCHAR(1) NOT NULL,
        Department VARCHAR(255) NOT NULL
    );

INSERT INTO employees (FirstName, LastName, Gender, Department) VALUES ('Anton', 'Zaslavski', 'M', 'Clarity');
INSERT INTO employees (FirstName, LastName, Gender, Department) VALUES ('元貴', ' 大森', 'M', 'Attitude');
INSERT INTO employees (FirstName, LastName, Gender, Department) VALUES ('宇鹏', '陈', 'M', 'The Shimmering Voyage');
INSERT INTO employees (FirstName, LastName, Gender, Department) VALUES ('Charlotte', 'Aitchison', 'F', 'brat');
INSERT INTO employees (FirstName, LastName, Gender, Department) VALUES ('Porter', 'Robinson', 'M', 'Nurture');
