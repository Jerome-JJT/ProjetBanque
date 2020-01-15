
INSERT INTO `users` (`id`, `iban`, `active`, `type`, `email`, `password`, `money`) VALUES
	(1, 'CH11 111', 1, 'Public', 'jerome@mail', '$BANQUEHASH$V1$10000$mRFwijjaYceQpZnsyQz7quqmxK7p7xsiGReBsg2AO3FDU3y9', 10000.5),
	(2, 'CH22 222', 1, 'Public', 'jerome@me', '$BANQUEHASH$V1$10000$v5cWt1aGdwMhNBtU32ybtKXQVDCGlRbGiPcj8RknUqP7fqc8', 10000.5),
	(3, 'CH33 333', 1, 'Enterprise', 'jerome@test', '$BANQUEHASH$V1$10000$IfJVKdPhyaPBOGzWPfUs+mnARXECvOsip5IGFHyK4kLBAJHg', 10000.5),
	(4, 'CH44 444', 1, 'Enterprise', 'jerome@jerome', '$BANQUEHASH$V1$10000$TFR3t+YhM0HJGTBppCb9HUiquuOo0qt+QQ/XdbpFPruuImvE', 10000.5);
	
	
INSERT INTO `transactions` (`id`, `date`, `amount`, `reason`, `idReceiver`, `idSender`) VALUES
             (3, '2019-12-20 17:51:41', 20, 'Tu est top\'cool', 2, 1),
             (4, '2019-12-20 17:53:51', 50, 'Salaire', 2, 1),
             (5, '2019-12-20 17:55:06', 42, 'Payement', 2, 1),
             (6, '2019-12-20 17:56:21', 8, 'Test1', 2, 1),
             (7, '2019-12-20 17:56:23', 8, 'Test2', 2, 1),
             (8, '2019-12-20 17:56:24', 8, 'Test3', 2, 1),
             (9, '2019-12-20 17:56:24', 8, 'Test4', 2, 1),
             (10, '2019-12-20 17:58:48', 76, 'Test5', 2, 1),
             (11, '2019-12-20 17:59:45', 100, 'Test6', 2, 1),
             (12, '2019-12-20 18:23:26', 100, 'Test7', 2, 1),
             (13, '2019-12-20 18:25:21', 100, 'Test8', 2, 1),
             (14, '2019-12-20 18:26:21', 41500, 'Test9', 2, 1),
             (15, '2019-12-20 18:30:44', 1000, 'Test0', 1, 3),
             (16, '2019-12-20 18:32:50', 150, 'mcDo', 1, 3),
             (17, '2019-12-20 18:35:35', 20, 'burger king', 1, 3);
             
             



INSERT INTO `lists` (`id`, `name`, `idUser`) VALUES
	(1, 'CH44 444_salaireEnt1', 4),
	(2, 'CH44 444_Famille', 4),
	(3, 'CH44 444_Amis', 4),
	(5, 'CH44 444_Visul studio', 4),
	(6, 'CH33 333_salaireEnterprise2', 3),
	(7, 'CH33 333_Cadeaux', 3);
	
	
INSERT INTO `users_lists` (`id`, `idList`, `idUser`) VALUES
	(1, 1, 1),
	(2, 1, 2),
	(3, 1, 3),
	(4, 2, 1),
	(5, 2, 2),
	(6, 3, 1),
	(7, 3, 3),
	
	(8, 5, 2),
	(9, 5, 3),
	
	(10, 6, 1),
	(11, 6, 4),
	
	(12, 7, 1),
	(13, 7, 2);
























