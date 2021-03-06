USE [SistemiMenaxhimitPersonelit]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 17/5/2020 10:34:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nchar](20) NULL,
	[Password] [nchar](20) NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organizata]    Script Date: 17/5/2020 10:34:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organizata](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Organizata] [nvarchar](max) NOT NULL,
	[Pershkrimi] [nvarchar](300) NULL,
 CONSTRAINT [PK_Organizata] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 17/5/2020 10:34:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [nvarchar](max) NOT NULL,
	[Mbiemri] [nvarchar](max) NOT NULL,
	[Adresa] [nvarchar](max) NOT NULL,
	[Gjinia] [nvarchar](1) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Ditelindja] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PervojaPunes]    Script Date: 17/5/2020 10:34:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PervojaPunes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrganizataID] [int] NOT NULL,
	[PersoniID] [int] NOT NULL,
	[VitePervoje] [int] NOT NULL,
	[Pergjegjesite] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_PervojaPunes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([ID], [Username], [Password]) VALUES (1, N'Mensur              ', N'mensur123           ')
INSERT [dbo].[Login] ([ID], [Username], [Password]) VALUES (2, N'Mirsad              ', N'mirsad123           ')
INSERT [dbo].[Login] ([ID], [Username], [Password]) VALUES (3, N'Jeton               ', N'jeton123            ')
SET IDENTITY_INSERT [dbo].[Login] OFF
SET IDENTITY_INSERT [dbo].[Organizata] ON 

INSERT [dbo].[Organizata] ([ID], [Organizata], [Pershkrimi]) VALUES (1004, N'QSNFtpYQ4lET5JVTzomOcEWoe7O0RU3e4ZnymJ2OXtkO8sSIME2fbZJEP7GeiXs6hI81bVvvMeZbkf9Znmil/lqmDmYhL4LuampLVTiewgXfGTghQ0VMoIvkbp5c4T/wogNsh0XKYfYE+J2UEAgZct8lvIxPZpxxnjXIkqGObUY=', N'fk546GVcKcMoDFQQ2L7uJ2R2ncWPzQXJOeepoJUrvVa3FQkmHMzwVR3a1mvmqMgm9xGpKTLiha9MybhOXyVCJS/bJIwND6d8nrUlVfkgTGAkh4BZAxgSqnvfkuLYb9WdiDel13u9HN8P0CTVmmtw9Ou1ZzUNhT6WttWl5oOBER8=')
INSERT [dbo].[Organizata] ([ID], [Organizata], [Pershkrimi]) VALUES (1005, N'b16vyuOuswLjDEbDLvJdQYtlP474pPnCPqAF8tkSy/7mFua4H3saXnWilFvbN8nyd+CrzP910Ftid9DGZkTPb8BIicxzmE2Zh3Md1J4mkHDSwp0RAfcuMVRUQJpgnshQ3h9TFwVGzRobZ4S1Zi4qXHd4FP6/A42Lg1awxCH45eg=', N'VdG7kx3qNB118fGQVGkFsRtcHDMZmrm6cbF+0g2v2W5E92YPjfLM1ZuOOQtQf4zXVSB/ZkodiVG11lCz+ZqWKzDDLfp5CGLSzCz5GkBrDvpkVb72Cp1SuiNpDCqjP1IO2wtlWbwar46eX7yLewHHOLBR8TqFd3GYbTl+RdOiPGQ=')
INSERT [dbo].[Organizata] ([ID], [Organizata], [Pershkrimi]) VALUES (1006, N'cUizkw+cSkKCIJu8urvscenZojuNPB8oaDMDR0pKFaml7oTMC0gTBOdqhsutnKweLXd1C+L+L6A3cexb4oHLayVo/Ap6a8jd5ecgZakGHGO2jfO1p07S20ZB88AF7KRbq/9/Oocbx3prC72J/jR4hzwfS9Ez7i6avhumPCh/M+U=', N'dspRY4O4sPMCYC2rRJUSDYt8q0zM2vcrHHY7AT+XlXj1PPHDdiWpCpLGMj+rdOKqiEA3XMrjZOyOKUBrHSnTwWbiEP71lTkOkJaesS/Ue84wjCk+bPofNiY1KFS6oIvalvPd6amgzozBUehOMSWxR6eUzv1vPpxb1OIk2jGxi5g=')
INSERT [dbo].[Organizata] ([ID], [Organizata], [Pershkrimi]) VALUES (1007, N'18mPbrxMIsMElbRT/HAgzK+4AkpUpNVFfjgk8bmVomhn4BwOynbCGWeWJ9UMQsGpt6gwryRcTJuAoI2639VzVAi9CpJnaOuqNriC6YMwzk0guIYAQWN4bMFu7moI29lQJjpVBA+5EfB/Zw705pJ/C70IwPeR6lBo1IrnNTHHmEg=', N'CsgVewg3+mw7Ab7vSBkz/FG9TpstqSG/TOearHHu6HQn4zGs6B/KDL/FpSk5UqCwBsoANaS0R2bXk0Hz/4eHo58q//jVpGjqlgDr+tDNc1b5xOy5CWvSGW8N/6p/h8LIj6kX3kk8C5SmIm2y+ZFuMppDWB4/UtaJMDixZFFQVRY=')
INSERT [dbo].[Organizata] ([ID], [Organizata], [Pershkrimi]) VALUES (1010, N'KK3JJITh0Vdi/djckG1m2i2ucjSGMywGL7vX7ubQorc0Mg6KEt4f+pOPX+HDyEfJtAFawQ+8IV7ngjmYJ7iAN8azrqv6xGaY18SCZO1jt6E471yETw+694tzzorWSbs42zxdL0Qjj4fQjyG9S0/bfPLkgZwmlCcUHhxedZXurAE=', N'XYdyjpOX1zQzcHqv+v/crpLWojSlgVKaFDtrsTQ5Y9MyhJ/vUj+gWCnqSdJjbfwp19x5GiGkhkYVHNChWUj59Wx7z1Jo9YOqCj1830R8kzojofdtWsnnX/5LHfttJaq5fC0wXLtfJq0RDW2WrsQ/SufxdDaw0diPmI2023wR9ws=')
INSERT [dbo].[Organizata] ([ID], [Organizata], [Pershkrimi]) VALUES (1012, N'mqT5KVjFA5becktfPbAZGjtmodEefgMTV5dqUiRBy/bAhRaJ3oywpSegTejf3EOR41MF4VVT+KcZZ/5xDq6uwMNK98DW/utGgLEQHPGdsd1QRIdp2vUIkKy3IROHJWFc3QTbqbbqbnIKX7wTg+sVksIVnAJp4+z6Vd8HFBhIkX4=', N'q4YFKWZeVcI+6ez2ZTSFNb1iRW4RrH5s1hE6synd9I5LITFExgV+lhGfSUrlQAqpcbRyH1RlWM995wpyIdpBC/VZIrSJnQhv35jiHrPwDqIbXONwt/NDNiOTYPOiREwyDvIIWvnHGbm/Rqok+7x4EXzWOdgvKe6hs2YMNyx0DYQ=')
INSERT [dbo].[Organizata] ([ID], [Organizata], [Pershkrimi]) VALUES (1013, N'sn+jqYo8KaROjzopEeEJ36UfayQ4mh0sYDq6uFGLOVe7gEirP63w47Rw+APLHVeJ4HSuGj7OCXEV+gCzJt/hE5ZVCStjSzCUgygR7Cfeu57bOZPJ8xqUenuzmm8hQd55sxYAfKZBMX1lCaB70YzSp0KsW0RmOcb4Z77yT+Pz2KU=', N'odZ2B9wUgGWrWg8Sl3G8GBA55bdga0+DpbP8yvasqsNG1Vj5iQ35n5H8Yqo5/j6+C/gUj2b4+4MMeDFJdHJoFQ7vJGCUD+/g2TVQTXWu9UXSwBZ8i7/zuMGNcDV6SpnjIjkFzHkkDs5ZlhStTMzYq7o/XKRSusN0XS5Gb/ZaWc0=')
INSERT [dbo].[Organizata] ([ID], [Organizata], [Pershkrimi]) VALUES (1014, N'1Y5WjL4k+GhX3YiltwT1FM4H6xkHYAY/Nv1emDeMwJt4L3I5Cz+OlnGaD85z2gHImaLjVKIbNyAbFwCcLMLG78vgHXBcjL3gKW+S6snTC2rQgZKnbUXuEbS9NAEAz5ySoi7aIGwLyNT3kupjruyu1R/zvcvWyIxo7qSY3vY4+Ys=', N'z9F0VW5hU0JFPoVUypW2sfVT4sp8ufGz+SaNGCHkt2bkM03BTCOgxkvRqjD9g/NACooi93QfNzaSfXR8g3xLemBZSViAo1oNYpMOgXXIXPzwxMGMEi0EsQBnXIXxC2TojEtUQZCE8I55JRQTsHCC+7KqGH2fC/KNH4vXhYA5g6k=')
INSERT [dbo].[Organizata] ([ID], [Organizata], [Pershkrimi]) VALUES (1015, N'WMNaWm3cbX+kh9459cEFgZk6K7744IxISQhDRI0P9Fd5vTYIwfowXZtmIB5U589OROXWukRNiCA62dKiUd+gnVctKAlEDYGEPopfc0SL618l4jkaXp0rdbTi21n0I6eNSDeIV8Zn1/CLaNFTtZBHUNI/xSpWYvwMNf3A4Fkd8ig=', N'BXWip8iyUKZ7OnUPMiAuLmOwhv9preO1n8aiIgX2IiDs7U3xejT4m1KlZaV9B+hBONQ61xB9VwUgHl7zmvYjnRDv+z7XEkUkDxiz1/l323jZW7iyFesAm0nqbFuuQKQgSQ4VTHZ6NI1GW6VZph97ZxNF30K/N9MSewj82BnvYno=')
INSERT [dbo].[Organizata] ([ID], [Organizata], [Pershkrimi]) VALUES (1016, N'BAJTaebeIrwsvUMCmn5+rUnIa3pSQe8uhLCaJKJOI/YO7MenNIiFmNCqR4rq39ykQB4vWWJtNfAB8lezhbxyk8jdtv/mPbEw0Wz3CxLWrN5C/g6dgGxs6l/PZn3VTxsAou2RrcS5smzO4BvQomTEfMHaSofiouGsbe99aXIbB5k=', N'ePD23MxQEVm3Hivxbgn74WSCiHNINT6LKDbE8jZ0fSVYygmU0mIxqyBCc6lWYjeYuX7tVldPtUPQU366lcrofHZ6MO3EKEMhn/PXUSnScy540PsRsUygKDgYXCkhbkMHJpa6X36UMsxSBWU0eLN6S8rrI7I3t9jQ5PxtImdF2+A=')
INSERT [dbo].[Organizata] ([ID], [Organizata], [Pershkrimi]) VALUES (1017, N'UEfzsWRnit1V2YGFSyAUKPX+KwkOQ9O5os95AvYjqXYuUFalb85e4gstK1UILm/4TQG7ZVful+V3t+UDeYdQE/32i1vAcEiZGgtNOxqqYKdFz5e00h3MsIq1EsmgiR+7VvMFljHFD9QwghjPiN0QsARPu/GHJPliKMKYKi5Q3pk=', N'Ufkrr90S4ZTZFIDZyq1XrS4ZMeL5/+4vizcnBSe2b4xT/LYU66J6Jyfq0PNkvAxgXUI6XAygpEUnCI0eiO1YfKafuE5vblN7ZukEGEusKKT2YVsRC4EGSuBcfiq2wrYUY3XbMgEw0IwbIpdvK5iHlC/zbLAcKjj+VuJyR0hVfQA=')
INSERT [dbo].[Organizata] ([ID], [Organizata], [Pershkrimi]) VALUES (1019, N'hXDA1PZwlY9Pe5l92OTvMkVHICXSdFN1iG8w0Ni5kO5NFG9pq0N4gXvDDqWrqNL3tu/VioWiSHFT/N68FPrt+bjrypa1PDHxtQTO8nHx5Ys10d+WRaDOT5Kz2OUi8gSFEGXMuZgOsK1xZCA2uUlTHS2G8zAVRxqinwlMOw4xuWs=', N'Wg7e/Pb5ATGTU15qr/tl26pWrgKpynrHC9UIs9mBNbdyiZDLu5S4aM+iueIPSaBsk6r70glnoyshNkRKyZcms7ZESuJnNOfrLiuYVvpCCU7rh7MUXhRoApUM5Ty/Us8okihx4L96+pOTCUCuYHqDINsH45w1Q/1Jpw8AGkyZw4E=')
INSERT [dbo].[Organizata] ([ID], [Organizata], [Pershkrimi]) VALUES (1020, N'XhtLpiQdQjGfveSGbrDgTXJocyFkI6oxXjOqsGGlSdPQTXVrqT0J839BzqPzYMuN0iHTVyD3k3OlE/9Wdjj4h1ewPz63z769hPXzeh6Ap73UXbORIpzYwWsltWQ2KCu0rlEePniAJb6M3WBByDIPt1+vYyGYyLVyIJvwKNln78w=', N'D1DPtkdTZCiBGQhyw7M8x25aKDVcb6J87GnFZ67nir4AyJEMK8NyvmoHWgXyFv3Z4N8jCwfYUT97D149o7B9yNARsvris6Af+NEcdJMA73lrLNWQ+cqm76ovJCOXED9jKCqZTHCoU7pJD42BEi4cR5VJF8Bu79wTGcJQUzcwoSE=')
INSERT [dbo].[Organizata] ([ID], [Organizata], [Pershkrimi]) VALUES (1021, N'QrSBOrb733WRfyjBTFz+FfH6EoK0cXm34Wa6ZaixWQIzSCDmO9HHqlM0fVZ4yryF9ihjD2hfXErHc7oeM5+A9zpYwmk0rSPvKlQHNc3eJkppyPIR4qKk61fd++aDzt/kkF0ny0E4nN/oPTgq4soZ+heUTOBSmsQyYhbjRmmgcFk=', N'sQBa69Us3z0UuPuhrfbWSwW8W+abrbRmbL9Jsl0xIOvu4G2DMozHjM3MgiqHLMWXCvlET89lFPzDfIDz/kx3hTqPmAKzKSkGVDyS2Iig8jay3Ts4M9xtW7CeRcoJ10mr+vZ6YWYVTUQa3seYFDZ8QcQoqH4LzV0b/GzbYX4c3a4=')
INSERT [dbo].[Organizata] ([ID], [Organizata], [Pershkrimi]) VALUES (1022, N'rUrELRnpoL0RNs2+I5WP25/iOlysVcF8qAIBws3D4WAxjCCwYTRAzhfE56ttgTwfBs4fiPeyMl6qHTz+UvPP1OtsdWkc5HonjFZzybUQFrYlOfKF0MenHVd2L2TCQw5S5JjM8Sz5Axn2jZpmAv8dcBeC1/B/Kuunk1x0UFX+kr8=', N'Z/Fm9V10guEuNZjTEnJPFFDMwEzAKXSz8en+G9LdRBNWBRlicA3Xc0rmHXhYsttu04sgFL1patB77YioHDCtyshr/2DkVzhfKCJLKyA1/xI986/xdub4yEC5qpFE4/9olbAtciOwp8jBymyITDksMEGAgWy7rOP6DqYT6Z7R31g=')
INSERT [dbo].[Organizata] ([ID], [Organizata], [Pershkrimi]) VALUES (1023, N'f8hl/+qWlSvjj9SL0yx4t8VM0UHqIo+tfT0GFmn3CLWKiuhKjAY3RWSmQYV+TXTedUv8WbsBn2fE6osQce4R9QgIOBnXgw2v48+Ph2jmzL0cH1vESV17LZWwEk75x+lA7UdzxV8J5butZsfBTV+ExPF/pS0db3H0VZvNvUtotqI=', N'utZeCu0JSA4bvQvwI1TSruJugnkU+AiwsZYP2WjqmVU8s9DTBE7P1Zy5mPzHUbOS4TYBu7cgIkVb7t8tDOfdOHZJ9YxBt6KsRaQtHyvmKcxmWSTe284+s606ps/kgpo02/YeJxBZu4fF7SkIldD12Lb1/iyZo5CT2lt1Lp4khjQ=')
SET IDENTITY_INSERT [dbo].[Organizata] OFF
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([ID], [Emri], [Mbiemri], [Adresa], [Gjinia], [Email], [Ditelindja]) VALUES (5, N'TayfQq0pk3mkkfrdx1xg7FopjjiDnSdo1NcISwEOheKRC/f1dEtwlTXk83p1ESXdVG8yRgI1mjKTnw0Bco1+TKvixk1XcJJSzkV5blv5T3HyHDUFt4fKf4lsuP2g2xMGt2QjMskfjPthZQ5hK7Q9iL2BcJVtwRQyRM9UmO2Ywjs=', N'RADXkmiW3KwUXRgq1Llf0ng3xDeEGiOIJqpPAN421iEBw3qJpztGSSKTaGbHMXkwlPoy/uf70ccAVWnrCbKT4UqzIwz/GcgN6jpN8IqwCG6MUmcS6Z+39aiW/36/6XGmrB636u/Rxfy2Z7rRUNz52yC9OxE+jzjVRCuBYagEla8=', N'eaOacMP6s/+nX61SUMtw8FIxIC/9/8lf3LYPAldz4KcyHPMqCSgd/77U7lBFNp6bvVlTgJorJd+n/T7nGLym0A8S+R47KlEFQaVac1U/T+0B/haPJYH378d48oK8SIL99ojNBctrIb0rOS59MRPi78s7ECTs2BiOY74OP6tP7VQ=', N'M', N'mirsadsyla@gmail.com', N'16-05-2020')
SET IDENTITY_INSERT [dbo].[Personel] OFF
SET IDENTITY_INSERT [dbo].[PervojaPunes] ON 

INSERT [dbo].[PervojaPunes] ([ID], [OrganizataID], [PersoniID], [VitePervoje], [Pergjegjesite]) VALUES (11, 1005, 5, 2, N'enUjDo0SuuA6fZAaNsknZWwrJo0jYG1hFbKQgDwdpOZ2klLeDrfQxo+rtEq9/Jf9Jf8BektXrExiOszMq2DsQHotK4vXMr87uCoyQbU9RJ+voGdJ4ZbOzCUK9HjTPRTSatBAGSdxKe5cOOhQymEDVDLUvfGJEzMjZKmJSuHGytY=')
SET IDENTITY_INSERT [dbo].[PervojaPunes] OFF
ALTER TABLE [dbo].[PervojaPunes]  WITH CHECK ADD  CONSTRAINT [FK_PervojaPunes_Organizata] FOREIGN KEY([OrganizataID])
REFERENCES [dbo].[Organizata] ([ID])
GO
ALTER TABLE [dbo].[PervojaPunes] CHECK CONSTRAINT [FK_PervojaPunes_Organizata]
GO
ALTER TABLE [dbo].[PervojaPunes]  WITH CHECK ADD  CONSTRAINT [FK_PervojaPunes_Personel] FOREIGN KEY([PersoniID])
REFERENCES [dbo].[Personel] ([ID])
GO
ALTER TABLE [dbo].[PervojaPunes] CHECK CONSTRAINT [FK_PervojaPunes_Personel]
GO
