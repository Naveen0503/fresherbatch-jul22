                                  --ASSIGNMENT3--

SELECT * FROM CUSTOMER

SELECT * FROM EMPLOYEE

SELECT * FROM [ORDER ]

SELECT * FROM PRODUCT

SELECT * FROM SHIP

CREATE PROCEDURE SPORDERDETAILS
@PHONE INT
AS
BEGIN
 SELECT PRODUCT.[PRODUCT-ID],ORDERITEM.[ORDER-ID],[ORDER ].[CUSTOMER-ID],CUSTOMER.PHONE,CONCAT(CUSTOMER.[FIRST-NAME],' ',CUSTOMER.[LAST-NAME]) AS CUSTOMERNAME FROM PRODUCT
 INNER JOIN ORDERITEM ON ORDERITEM.[PRODUCT-ID]=PRODUCT.[PRODUCT-ID]
 INNER JOIN [ORDER ] ON [ORDER ].[ORDER-ID]=ORDERITEM.[ORDER-ID]
 INNER JOIN CUSTOMER ON CUSTOMER.[CUSTOMER-ID]=[ORDER ].[CUSTOMER-ID]
 WHERE CUSTOMER.PHONE = @PHONE
END 
SPORDERDETAILS 0300074321



SELECT * FROM PRODUCT WHERE CATEGORY ='SEA-FOOD'


SELECT PRODUCT.[PRODUCT-NAME],ORDERITEM.[ORDER-ID],[ORDER ].[CUSTOMER-ID],CONCAT(CUSTOMER.[FIRST-NAME],' ',CUSTOMER.[LAST-NAME]) AS [CUSTOMER-NAME],CUSTOMER.COUNTRY FROM PRODUCT
INNER JOIN ORDERITEM ON ORDERITEM.[PRODUCT-ID]=PRODUCT.[PRODUCT-ID]
INNER JOIN [ORDER ] ON [ORDER ].[ORDER-ID]=ORDERITEM.[ORDER-ID]
INNER JOIN CUSTOMER ON CUSTOMER.[CUSTOMER-ID]=[ORDER ].[CUSTOMER-ID]
WHERE CUSTOMER.CITY != 'LONDON'

CREATE PROCEDURE SPPRODUCTDETAILS
@PRODUCT nvarchar(50)
AS 
BEGIN
SELECT PRODUCT.[PRODUCT-NAME],ORDERITEM.[ORDER-ID],CONCAT(CUSTOMER.[FIRST-NAME],' ',CUSTOMER.[LAST-NAME]) AS [CUSTOMER-NAME] FROM PRODUCT
INNER JOIN ORDERITEM ON ORDERITEM.[PRODUCT-ID]=PRODUCT.[PRODUCT-ID]
INNER JOIN [ORDER ] ON [ORDER ].[ORDER-ID]=ORDERITEM.[ORDER-ID]
INNER JOIN CUSTOMER ON CUSTOMER.[CUSTOMER-ID]=[ORDER ].[CUSTOMER-ID]
WHERE PRODUCT.[PRODUCT-NAME]=@PRODUCT 
END

SPPRODUCTDETAILS CHAI

SELECT CONCAT([EMP-FIRST-NAME],' ',[EMP-LAST-NAME]) AS [EMP-NAME],DEPARTMENT,[RATING OF EMPLOYE] FROM EMPLOYEE ORDER BY [RATING OF EMPLOYE] ASC

