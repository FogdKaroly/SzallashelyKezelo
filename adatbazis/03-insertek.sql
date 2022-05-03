use szallashely_kezelo;

insert into szallashely(id, fajta, iranyitoszam, varos, utca, hazszam) VALUES('üa000001', 'üzleti', '2170', 'Aszód', 'Kossuth utca', '15.');
insert into szallashely(id, fajta, iranyitoszam, varos, utca, hazszam) VALUES('sbp00001', 'sport', '1111', 'Budapest', 'Petõfi utca', '1.');
insert into szallashely(id, fajta, iranyitoszam, varos, utca, hazszam) VALUES('gyk00001', 'gyógy', '2143', 'Kistarcsa', 'Deák Ferenc utca', '8.');
insert into szallashely(id, fajta, iranyitoszam, varos, utca, hazszam) VALUES('ebp00001', 'egyéb', '1123', 'Budapest', 'Liget utca', '34.');

insert into epitett_szallashely(szallashely_id, szoba_ara, csillagok) VALUES('üa000001', 15000, 3);
insert into epitett_szallashely(szallashely_id, szoba_ara, csillagok) VALUES('gyk00001', 26000, 4);
insert into epitett_szallashely(szallashely_id, szoba_ara, csillagok) VALUES('ebp00001', 10000, 3);

insert into szalloda(epitett_id, wellness) VALUES(2, 1);

insert into panzio(epitett_id, reggeli) VALUES(1, 1);

insert into camping(szallashely_id, vizpart) VALUES('sbp00001', 0);