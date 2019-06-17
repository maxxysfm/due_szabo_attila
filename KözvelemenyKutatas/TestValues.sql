DELETE FROM LEADOTTVALASZOK;
DELETE FROM VALASZOK;
DELETE FROM KERDESEK;
DELETE FROM FELHASZNALOIADATOK;
DELETE FROM KUTATASOK;

--Átdolgozás előtt milyen értékek voltak elfogadva csak a VEGZETTSEG-be.
--INSERT INTO ISKOLAIVEGZETTSEG VALUES (1,'Általános Iskola');
--INSERT INTO ISKOLAIVEGZETTSEG VALUES (2,'Gimnázium');
--INSERT INTO ISKOLAIVEGZETTSEG VALUES (3,'Szakközépiskola');
--INSERT INTO ISKOLAIVEGZETTSEG VALUES (4,'Szakiskola');
--INSERT INTO ISKOLAIVEGZETTSEG VALUES (5,'Felsőoktatási intézmény');
--FELHASZNÁLÓI ADATOK--
INSERT INTO FELHASZNALOIADATOK
VALUES ('maxxywarrior@gmail.com','Férfi',21,'Szakközépiskola');
INSERT INTO FELHASZNALOIADATOK
VALUES ('vellyvice@citromail.hu','Férfi',30,'Szakiskola');
INSERT INTO FELHASZNALOIADATOK
VALUES ('roleplayer21@gmail.hu','Nő',25,'Felsőoktatási intézmény');
INSERT INTO FELHASZNALOIADATOK
VALUES ('drowranger@gmail.hu','Nő',40,'Felsőoktatási intézmény');
INSERT INTO FELHASZNALOIADATOK
VALUES ('gabenewell@gmail.hu','Férfi',55,'Felsőoktatási intézmény');
--KUTATÁSOK--
--Aktív kutatás--
INSERT INTO KUTATASOK
VALUES ('Aktív kutatás','2017-11-23 10:34:09','2017-12-15 10:00:00',3,1);
--KÉRDÉSEK ÉS VÁLASZOK--
INSERT INTO KERDESEK
VALUES (1,'Aktív kutatás','Kék vagy zöld?');

INSERT INTO VALASZOK
VALUES (1,1,'Kék');
INSERT INTO VALASZOK
VALUES (1,2,'Zöld');

INSERT INTO KERDESEK
VALUES (2,'Aktív kutatás','Tyúk vagy a tojás?');

INSERT INTO VALASZOK
VALUES (2,3,'Tyúk');
INSERT INTO VALASZOK
VALUES (2,4,'Tojás');


--Nem aktív kutatás--
INSERT INTO KUTATASOK
VALUES ('Nem aktív kutatás','2017-12-23 10:34:09','2018-01-05 10:00:00',5,0);
--KÉRDÉSEK ÉS VÁLASZOK--
INSERT INTO KERDESEK
VALUES (3,'Nem aktív kutatás','X vagy Y?');

INSERT INTO VALASZOK
VALUES (3,5,'X');
INSERT INTO VALASZOK
VALUES (3,6,'Y');

--Lejárt kutatás--
INSERT INTO KUTATASOK
VALUES ('Lejárt kutatás','2017-12-23 10:34:09','2018-01-05 10:00:00',5,0);
--KÉRDÉSEK ÉS VÁLASZOK--
INSERT INTO KERDESEK
VALUES (4,'Lejárt kutatás','Válasz1 vagy Válasz2?');

INSERT INTO VALASZOK
VALUES (4,7,'Válasz1');
INSERT INTO VALASZOK
VALUES (4,8,'Válasz2');

--LEADOTT VÁLASZOK--
--maxxywarrior@gmail.com--
INSERT INTO LEADOTTVALASZOK
VALUES (1,'maxxywarrior@gmail.com',1,1);
INSERT INTO LEADOTTVALASZOK
VALUES (2,'maxxywarrior@gmail.com',2,3);
--drowranger@gmail.hu--
INSERT INTO LEADOTTVALASZOK
VALUES (3,'drowranger@gmail.hu',1,2);
--roleplayer21@gmail.hu--
INSERT INTO LEADOTTVALASZOK
VALUES (4,'roleplayer21@gmail.hu',1,1);
INSERT INTO LEADOTTVALASZOK
VALUES (5,'roleplayer21@gmail.hu',2,3);
--vellyvice@citromail.hu--
INSERT INTO LEADOTTVALASZOK
VALUES (6,'vellyvice@citromail.hu',1,2);
--gabenewell@gmail.hu--
INSERT INTO LEADOTTVALASZOK
VALUES (7,'gabenewell@gmail.hu',1,2);
INSERT INTO LEADOTTVALASZOK
VALUES (8,'gabenewell@gmail.hu',2,3);
INSERT INTO LEADOTTVALASZOK
VALUES (9,'gabenewell@gmail.hu',4,7);