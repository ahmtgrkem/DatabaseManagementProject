CREATE SCHEMA kisi;

--iller
CREATE TABLE "Iller" (
    "il_id" SERIAL,
    "ad" VARCHAR(100) NOT NULL,
    CONSTRAINT "ilPK" PRIMARY KEY("il_id")
);

--iller
INSERT INTO "Iller" ("ad") VALUES
('Adana'),
('Adıyaman'),
('Afyonkarahisar'),
('Ağrı'),
('Amasya'),
('Ankara'),
('Antalya'),
('Artvin'),
('Aydın'),
('Balıkesir'),
('Bilecik'),
('Bingöl'),
('Bitlis'),
('Bolu'),
('Burdur'),
('Bursa'),
('Çanakkale'),
('Çankırı'),
('Çorum'),
('Denizli'),
('Diyarbakır'),
('Edirne'),
('Elazığ'),
('Erzincan'),
('Erzurum'),
('Eskişehir'),
('Gaziantep'),
('Giresun'),
('Gümüşhane'),
('Hakkâri'),
('Hatay'),
('Isparta'),
('Mersin'),
('İstanbul'),
('İzmir'),
('Kars'),
('Kastamonu'),
('Kayseri'),
('Kırklareli'),
('Kırşehir'),
('Kocaeli'),
('Konya'),
('Kütahya'),
('Malatya'),
('Manisa'),
('Kahramanmaraş'),
('Mardin'),
('Muğla'),
('Muş'),
('Nevşehir'),
('Niğde'),
('Ordu'),
('Rize'),
('Sakarya'),
('Samsun'),
('Siirt'),
('Sinop'),
('Sivas'),
('Tekirdağ'),
('Tokat'),
('Trabzon'),
('Tunceli'),
('Şanlıurfa'),
('Uşak'),
('Van'),
('Yozgat'),
('Zonguldak'),
('Aksaray'),
('Bayburt'),
('Karaman'),
('Kırıkkale'),
('Batman'),
('Şırnak'),
('Bartın'),
('Ardahan'),
('Iğdır'),
('Yalova'),
('Karabük'),
('Kilis'),
('Osmaniye'),
('Düzce');


--kişi
CREATE TABLE "kisi"."Kisi" (
    "kisi_id" SERIAL,
    "il_id" INT,
    "ad" VARCHAR(100) NOT NULL,
    "soyad" VARCHAR(100) NOT NULL,
    "dogum_tarihi" DATE NOT NULL,
    "cinsiyet" BOOLEAN,--1 erkek, 0 kadın
    "tel_no" VARCHAR(15),
    "kisi_tipi" CHAR(1) NOT NULL,--Sporcu(1),Antrenör(2),Personel(3)
    CONSTRAINT "kisiPK" PRIMARY KEY("kisi_id"),
    CONSTRAINT "ilFK" FOREIGN KEY("il_id") REFERENCES "Iller"("il_id")
        ON DELETE SET NULL
        ON UPDATE CASCADE
);

--antrenmanlar
CREATE TABLE "Antrenmanlar" (
    "antrenman_id" SERIAL,
    "ad" VARCHAR(50),
    "tur" VARCHAR(50),
    "zorluk" VARCHAR(10),
    CONSTRAINT "antrenmanPK" PRIMARY KEY("antrenman_id")
);

--branslar
CREATE TABLE "Branslar" (
    "brans_id" SERIAL,
    "ad" VARCHAR(50),
    "tur" VARCHAR(50),
    CONSTRAINT "bransPK" PRIMARY KEY("brans_id")
);

--salon
CREATE TABLE "Salonlar" (
    "salon_id" SERIAL,
    "il_id" INT NOT NULL,
    "ad" VARCHAR(50) NOT NULL,
    "kapasite" INT,
    CONSTRAINT "salonPF" PRIMARY KEY("salon_id"),
    CONSTRAINT "ilFK" FOREIGN KEY("il_id") REFERENCES "Iller"("il_id")
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

--sporcu
CREATE TABLE "kisi"."Sporcu" (
    "kisi_id" INT,
    "antrenman_id" INT NOT NULL,
    "brans_id" INT NOT NULL,
    "sporcu_durumu" VARCHAR(50),
    CONSTRAINT "sporcuPK" PRIMARY KEY("kisi_id"),
    CONSTRAINT "kisiFK" FOREIGN KEY("kisi_id") REFERENCES "kisi"."Kisi"("kisi_id")
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    CONSTRAINT "antrenmanFK" FOREIGN KEY("antrenman_id") REFERENCES "Antrenmanlar"("antrenman_id")
        ON DELETE SET NULL
        ON UPDATE CASCADE,
    CONSTRAINT "bransFK" FOREIGN KEY("brans_id") REFERENCES "Branslar"("brans_id")
        ON DELETE SET NULL
        ON UPDATE CASCADE
);

--antrenörler
CREATE TABLE "kisi"."Antrenor" (
    "kisi_id" INT,
    "calisma_tipi" VARCHAR(50),
    "baslama_tarihi" DATE,
    CONSTRAINT "antrenorPK" PRIMARY KEY("kisi_id"),
    CONSTRAINT "kisiFK" FOREIGN KEY("kisi_id") REFERENCES "kisi"."Kisi"("kisi_id")
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

--personel
CREATE TABLE "kisi"."Personel" (
    "kisi_id" INT,
    "salon_id" INT NOT NULL,
    "calisma_tipi" VARCHAR(50),
    "gorev" VARCHAR(100),
    CONSTRAINT "personelPK" PRIMARY KEY("kisi_id"),
    CONSTRAINT "kisiFK" FOREIGN KEY("kisi_id") REFERENCES "kisi"."Kisi"("kisi_id")
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    CONSTRAINT "salonFK" FOREIGN KEY("salon_id") REFERENCES "Salonlar"("salon_id")
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

--antrenör_sporcu
CREATE TABLE "Antrenor_Sporcu" (
    "as_id" SERIAL,
    "antrenor_id" INT NOT NULL,
    "sporcu_id" INT NOT NULL,
    CONSTRAINT "antrenorSporcuPK" PRIMARY KEY("as_id"),
    CONSTRAINT "antrenorFK" FOREIGN KEY("antrenor_id") REFERENCES "kisi"."Antrenor"("kisi_id")
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    CONSTRAINT "sporcuFK" FOREIGN KEY("sporcu_id") REFERENCES "kisi"."Sporcu"("kisi_id")
        ON DELETE CASCADE
        ON UPDATE CASCADE
);


--sporcu_salon
CREATE TABLE "Sporcu_Salon" (
    "ss_id" SERIAL,
    "sporcu_id" INT NOT NULL,
    "salon_id" INT NOT NULL,
    CONSTRAINT "sporcuSalonPK" PRIMARY KEY("ss_id"),
    CONSTRAINT "sporcu_salon_sporcu_fk" FOREIGN KEY ("sporcu_id") REFERENCES "kisi"."Sporcu" ("kisi_id")
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    CONSTRAINT "sporcu_salon_salon_fk" FOREIGN KEY ("salon_id") REFERENCES "Salonlar" ("salon_id")
        ON DELETE CASCADE
        ON UPDATE CASCADE
);


--antrenor_brans
CREATE TABLE "Antrenor_Brans" (
    "ab_id" SERIAL,
    "antrenor_id" INT NOT NULL,
    "brans_id" INT NOT NULL,
    CONSTRAINT "antrenorBransPK" PRIMARY KEY("ab_id"),
    CONSTRAINT "antrenorFK" FOREIGN KEY("antrenor_id") REFERENCES "kisi"."Antrenor"("kisi_id")
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    CONSTRAINT "bransFK" FOREIGN KEY("brans_id") REFERENCES "Branslar"("brans_id")
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

--oduller
CREATE TABLE "Oduller" (
    "odul_id" SERIAL,
    "ad" VARCHAR(100) NOT NULL,
    "odul_miktari" NUMERIC(10,2),
    "odul_sayisi" INT,
    CONSTRAINT "odulPK" PRIMARY KEY("odul_id")
);

--turnuvalar
CREATE TABLE "Turnuvalar" (
    "turnuva_id" SERIAL,
    "brans_id" INT NOT NULL,
    "odul_id" INT NOT NULL,
    "il_id" INT NOT NULL,
    "ad" VARCHAR(100) NOT NULL,
    "tarih" DATE NOT NULL,
    CONSTRAINT "turnuvaPK" PRIMARY KEY("turnuva_id"),
    CONSTRAINT "bransFK" FOREIGN KEY("brans_id") REFERENCES "Branslar"("brans_id")
        ON DELETE SET NULL
        ON UPDATE CASCADE,
    CONSTRAINT "odulFK" FOREIGN KEY("odul_id") REFERENCES "Oduller"("odul_id")
        ON DELETE SET NULL
        ON UPDATE CASCADE,
    CONSTRAINT "ilFK" FOREIGN KEY("il_id") REFERENCES "Iller"("il_id")
        ON DELETE SET NULL
        ON UPDATE CASCADE
);

--sporcu_turnuva
CREATE TABLE "Sporcu_Turnuva" (
    "st_id" SERIAL,
    "sporcu_id" INT NOT NULL,
    "turnuva_id" INT NOT NULL,
    CONSTRAINT "sporcuTurnuvaPK" PRIMARY KEY("st_id"),
    CONSTRAINT "sporcuFK" FOREIGN KEY("sporcu_id") REFERENCES "kisi"."Sporcu"("kisi_id")
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    CONSTRAINT "turnuvaFk" FOREIGN KEY("turnuva_id") REFERENCES "Turnuvalar"("turnuva_id")
        ON DELETE CASCADE
        ON UPDATE CASCADE
);


--ekipmanlar
CREATE TABLE "Ekipmanlar" (
    "ekipman_id" SERIAL,
    "salon_id" INT NOT NULL,
    "ad" VARCHAR(100) NOT NULL,
    "adet" INT,
    "durum" VARCHAR(50),
    CONSTRAINT "ekipmanPK" PRIMARY KEY("ekipman_id"),
    CONSTRAINT "salonFK" FOREIGN KEY("salon_id") REFERENCES "Salonlar"("salon_id")
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

--ekipman_brans
CREATE TABLE "Ekipman_brans" (
    "eb_id" SERIAL,
    "ekipman_id" INT NOT NULL,
    "brans_id" INT NOT NULL,
    CONSTRAINT "ekipmanBransPK" PRIMARY KEY("eb_id"),
    CONSTRAINT "ekipmanFK" FOREIGN KEY("ekipman_id") REFERENCES "Ekipmanlar"("ekipman_id")
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    CONSTRAINT "bransFK" FOREIGN KEY("brans_id") REFERENCES "Branslar"("brans_id")
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

CREATE OR REPLACE FUNCTION "kisiSayisiIl"(il_id INT)
RETURNS INT AS $$
DECLARE
    kisi_sayisi INT;
BEGIN
    SELECT COUNT(*) INTO kisi_sayisi
    FROM "kisi"."Kisi"
    WHERE "il_id" = il_id;
    RETURN kisi_sayisi;
END;
$$ LANGUAGE plpgsql;


CREATE OR REPLACE FUNCTION "sporcuTurnuvalari"(sporcu_id INT)
RETURNS TABLE(turnuva_id INT, turnuva_ad VARCHAR, tarih DATE) AS $$
BEGIN
    RETURN QUERY
    SELECT t."turnuva_id", t."ad", t."tarih"
    FROM "Turnuvalar" t
    JOIN "Sporcu_Turnuva" st ON t."turnuva_id" = st."turnuva_id"
    WHERE st."sporcu_id" = sporcu_id;
END;
$$ LANGUAGE plpgsql;


CREATE OR REPLACE FUNCTION "sporcuYasi"(kisi_id INT)
RETURNS INT AS $$
DECLARE
    dogum_tarihi DATE;
    yas INT;
BEGIN
    SELECT "dogum_tarihi" INTO dogum_tarihi
    FROM "kisi"."Kisi"
    WHERE "kisi_id" = kisi_id;
    
    IF dogum_tarihi IS NULL THEN
        RETURN NULL;
    END IF;
    
    SELECT EXTRACT(YEAR FROM AGE(CURRENT_DATE, dogum_tarihi)) INTO yas;
    RETURN yas;
END;
$$ LANGUAGE plpgsql;


CREATE OR REPLACE FUNCTION "salonEkipmanSayisi"(salon_id INT)
RETURNS INT AS $$
DECLARE
    toplam_adet INT;
BEGIN
    SELECT SUM("adet") INTO toplam_adet
    FROM "Ekipmanlar"
    WHERE "salon_id" = salon_id;
    
    RETURN COALESCE(toplam_adet, 0);
END;
$$ LANGUAGE plpgsql;


CREATE OR REPLACE FUNCTION "sporcuCinsiyetKontrolu"()
RETURNS TRIGGER AS $$
BEGIN
    IF NEW."cinsiyet" IS NULL THEN
        RAISE EXCEPTION 'Cinsiyet bilgisi eksik.';
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER "sporcuEkleCinsiyet"
BEFORE INSERT ON "kisi"."Sporcu"
FOR EACH ROW
EXECUTE FUNCTION "sporcuCinsiyetKontrolu"();


CREATE OR REPLACE FUNCTION "turnuvaTarihKontrolu"()
RETURNS TRIGGER AS $$
BEGIN
    IF NEW."tarih" < CURRENT_DATE THEN
        RAISE EXCEPTION 'Turnuva tarihi geçmiş bir tarih olamaz.';
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER "turnuvaEkleTarih"
BEFORE INSERT ON "Turnuvalar"
FOR EACH ROW
EXECUTE FUNCTION "turnuvaTarihKontrolu"();


CREATE OR REPLACE FUNCTION "sporcuDurumLog"()
RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO "Loglar" ("tablo_adi", "islem", "islem_tarihi", "kullanici")
    VALUES ('Sporcu', 'Durum güncellemesi', CURRENT_TIMESTAMP, SESSION_USER);
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER "sporcuDurumGuncelle"
AFTER UPDATE OF "sporcu_durumu" ON "kisi"."Sporcu"
FOR EACH ROW
EXECUTE FUNCTION "sporcuDurumLog"();


CREATE OR REPLACE FUNCTION "ekipmanSilLog"()
RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO "Loglar" ("tablo_adi", "islem", "islem_tarihi", "kullanici")
    VALUES ('Ekipmanlar', 'Ekipman silindi', CURRENT_TIMESTAMP, SESSION_USER);
    RETURN OLD;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER "ekipmanSil"
AFTER DELETE ON "Ekipmanlar"
FOR EACH ROW
EXECUTE FUNCTION "ekipmanSilLog"();
