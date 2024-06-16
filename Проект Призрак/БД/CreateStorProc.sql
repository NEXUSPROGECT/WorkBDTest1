DELIMITER //

CREATE PROCEDURE GetOrderDetails(IN orderNumber INT)
BEGIN
    SELECT 
        o.Number AS 'Номер поручения',
        ot.Type AS 'Тип сделки',
        ov.Veriety AS 'Вид сделки',
        o.Tiker AS 'Тикер ценной бумаги',
        o.Count AS 'Количество ценных бумаг',
        o.Type AS 'Тип поручения',
        o.Data AS 'Дата и время получения поручения',
        o.Duration AS 'Срок действия поручения'
    FROM _Order o
    JOIN OrderType ot ON o.OrderTypeID = ot.ID
    JOIN OrderVeriety ov ON o.OrderVerietyID = ov.ID
    WHERE o.Number = orderNumber;
END //

DELIMITER ;