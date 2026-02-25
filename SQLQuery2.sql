UPDATE VolunteerLog
SET ReceiptStatus = 'Pending'
WHERE ReceiptStatus IS NULL;