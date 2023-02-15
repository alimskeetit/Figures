# Figures
The IsRightTriangle() method needs to be modified in the class Triangle (see comments).
# SQL
## Creating tables

```
CREATE TABLE products(
id INTEGER PRIMARY KEY, 
name VARCHAR(255) NOT NULL);
```
```
CREATE TABLE categories(
id INTEGER PRIMARY KEY, 
name VARCHAR(255) NOT NULL);
```
```
CREATE TABLE ProductCategories (
ProductId INTEGER references products(id),
CategoryId INTEGER references categories(id),
PRIMARY KEY ("productid", "categoryid")
);
```
Products and Category are simple tables with id and name.  

ProductCategories is table with Product's and Category's ids.  

## Inserting into tables
```
INSERT INTO Products VALUES (1, 'Gibson Les Paul'), (2, 'TAMA'), (3, 'Car');  
INSERT INTO Categories VALUES (1, 'Guitars'), (2, 'Musical instruments'), (3, 'Drums');  
```
```
INSERT INTO ProductCategories VALUES (1,1), (1, 2), (2, 2), (2, 3);
INSERT INTO ProductCategories VALUES (3, null);  //without category
```
## Select
```
SELECT p.name, c.name FROM Products AS p
LEFT JOIN productcategories AS pc ON p.id = pc.productid 
LEFT JOIN categories AS c ON c.id = pc.categoryid;
```
Simple select by id
