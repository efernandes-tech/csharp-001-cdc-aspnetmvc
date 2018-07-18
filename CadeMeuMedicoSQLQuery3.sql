
CREATE TABLE BannersPublicitarios
(
	IDBanner BIGINT IDENTITY NOT NULL,
	TituloCampanha VARCHAR(60) NOT NULL,
	BannerCampanha VARCHAR(200) NOT NULL,
	LinkBanner VARCHAR(200) NULL,
	PRIMARY KEY(IDBanner)
);

INSERT INTO BannersPublicitarios (TituloCampanha, BannerCampanha, LinkBanner)
VALUES ('Campanha Conio', 'logo-conio-cademeumedico.png','http://conio.com.br')

INSERT INTO BannersPublicitarios (TituloCampanha, BannerCampanha, LinkBanner)
VALUES ('Campanha Casa do Código', 'banner-cdc-cademeumedico.png', 'http://casadocodigo.com.br')

Insert Into Usuarios (Nome, Login, Senha, Email)
Values ('Administrador', 'admin', '40BD001563085FC35165329EA1FF5C5ECBDBBEEF', 'admin@cdmm.com')
