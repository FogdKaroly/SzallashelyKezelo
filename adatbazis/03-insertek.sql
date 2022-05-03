use szallashely_kezelo;

insert into szallashely(id, fajta, iranyitoszam, varos, utca, hazszam) VALUES('�a000001', '�zleti', '2170', 'Asz�d', 'Kossuth utca', '15.');
insert into szallashely(id, fajta, iranyitoszam, varos, utca, hazszam) VALUES('sbp00001', 'sport', '1111', 'Budapest', 'Pet�fi utca', '1.');
insert into szallashely(id, fajta, iranyitoszam, varos, utca, hazszam) VALUES('gyk00001', 'gy�gy', '2143', 'Kistarcsa', 'De�k Ferenc utca', '8.');
insert into szallashely(id, fajta, iranyitoszam, varos, utca, hazszam) VALUES('ebp00001', 'egy�b', '1123', 'Budapest', 'Liget utca', '34.');

insert into epitett_szallashely(szallashely_id, szoba_ara, csillagok) VALUES('�a000001', 15000, 3);
insert into epitett_szallashely(szallashely_id, szoba_ara, csillagok) VALUES('gyk00001', 26000, 4);
insert into epitett_szallashely(szallashely_id, szoba_ara, csillagok) VALUES('ebp00001', 10000, 3);

insert into szalloda(epitett_id, wellness) VALUES(2, 1);

insert into panzio(epitett_id, reggeli) VALUES(1, 1);

insert into camping(szallashely_id, vizpart) VALUES('sbp00001', 0);