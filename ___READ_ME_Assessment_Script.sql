SELECT cus.*,
    cus.firstName + ' ' + cus.lastName AS fullName,
    cus.age,
    ord.orderID,
    ord.dateCreated,
    ord.methodOfPurchase,
    det.productNumber,
    det.productOrigin

FROM        d_customer      cus
INNER JOIN  d_order         ord ON (cus.personID = ord.personID)
INNER JOIN  d_orderDetails  det ON (ord.orderID  = det.orderID)

WHERE det.productID = 1112222333
ORDER BY fullName, orderID