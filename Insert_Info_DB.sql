  
	/* CAMBIAR EL VARCHAR(15) POR VARCHAR(25) */
    INSERT INTO Tipos_Roles VALUES('Administrador de Sistemas');
    INSERT INTO Tipos_Roles VALUES('Doctor');
    INSERT INTO Tipos_Roles VALUES('Enfermero');
    INSERT INTO Tipos_Roles VALUES('Secretario');
    
	/* CAMBIAR POR VARCHAR(60) */
	INSERT INTO Tipos_Areas VALUES('Alergología');
	INSERT INTO Tipos_Areas VALUES('Análisis clínicos');
    INSERT INTO Tipos_Areas VALUES('Anatomía patológica');
    INSERT INTO Tipos_Areas VALUES('Anestesiología y reanimación');
    INSERT INTO Tipos_Areas VALUES('Angiología y cirugía vascular');
    INSERT INTO Tipos_Areas VALUES('Bacteriología');
    INSERT INTO Tipos_Areas VALUES('Bioquímica clínica');
    INSERT INTO Tipos_Areas VALUES('Cardiología');
    INSERT INTO Tipos_Areas VALUES('Cirugía cardiovascular');
    INSERT INTO Tipos_Areas VALUES('Cirugía general y del aparato digestivo');
    INSERT INTO Tipos_Areas VALUES('Cirugía oral y maxilofacial');
    INSERT INTO Tipos_Areas VALUES('Cirugía ortopédica y traumatología');
    INSERT INTO Tipos_Areas VALUES('Cirugía pediátrica');
    INSERT INTO Tipos_Areas VALUES('Cirugía plástica, estética y reparadora');
    INSERT INTO Tipos_Areas VALUES('Cirugía torácica');
    INSERT INTO Tipos_Areas VALUES('Dermatología');
    INSERT INTO Tipos_Areas VALUES('Dietista nutricionista');
    INSERT INTO Tipos_Areas VALUES('Endocrinología');
    INSERT INTO Tipos_Areas VALUES('Enfermería');
    INSERT INTO Tipos_Areas VALUES('Estomatología');
    INSERT INTO Tipos_Areas VALUES('Farmacología clínica');
    INSERT INTO Tipos_Areas VALUES('Fisioterapia');
    INSERT INTO Tipos_Areas VALUES('Gastroenterología');
    INSERT INTO Tipos_Areas VALUES('Genética médica');
    INSERT INTO Tipos_Areas VALUES('Geriatría');
	INSERT INTO Tipos_Areas VALUES('General');
    INSERT INTO Tipos_Areas VALUES('Ginecología');
    INSERT INTO Tipos_Areas VALUES('Ginecología y obstetricia');
    INSERT INTO Tipos_Areas VALUES('Hematología y hemoterapia');
    INSERT INTO Tipos_Areas VALUES('Hidrología médica');
    INSERT INTO Tipos_Areas VALUES('Infectología');
    INSERT INTO Tipos_Areas VALUES('Inmunología');
    INSERT INTO Tipos_Areas VALUES('Medicina aeroespacial');
    INSERT INTO Tipos_Areas VALUES('Medicina de urgencias');
    INSERT INTO Tipos_Areas VALUES('Medicina del deporte');
    INSERT INTO Tipos_Areas VALUES('Medicina del trabajo');
    INSERT INTO Tipos_Areas VALUES('Medicina familiar y comunitaria');
    INSERT INTO Tipos_Areas VALUES('Medicina física y rehabilitación');
    INSERT INTO Tipos_Areas VALUES('Medicina intensiva');
    INSERT INTO Tipos_Areas VALUES('Medicina interna');
    INSERT INTO Tipos_Areas VALUES('Medicina legal y forense');
    INSERT INTO Tipos_Areas VALUES('Medicina nuclear');
    INSERT INTO Tipos_Areas VALUES('Medicina paliativa');
    INSERT INTO Tipos_Areas VALUES('Medicina preventiva y salud pública');
    INSERT INTO Tipos_Areas VALUES('Microbiología y parasitología');
    INSERT INTO Tipos_Areas VALUES('Nefrología');
    INSERT INTO Tipos_Areas VALUES('Neonatología');
    INSERT INTO Tipos_Areas VALUES('Neumología');
    INSERT INTO Tipos_Areas VALUES('Neurocirugía');
    INSERT INTO Tipos_Areas VALUES('Neurofisiología clínica');
    INSERT INTO Tipos_Areas VALUES('Neurología');
    INSERT INTO Tipos_Areas VALUES('Nutriología');
    INSERT INTO Tipos_Areas VALUES('Obstetricia');
    INSERT INTO Tipos_Areas VALUES('Odontología');
    INSERT INTO Tipos_Areas VALUES('Oftalmología');
    INSERT INTO Tipos_Areas VALUES('Oncología médica');
    INSERT INTO Tipos_Areas VALUES('Oncología radioterápica');
    INSERT INTO Tipos_Areas VALUES('Optometría');
    INSERT INTO Tipos_Areas VALUES('Otorrinolaringología');
    INSERT INTO Tipos_Areas VALUES('Pediatría');
    INSERT INTO Tipos_Areas VALUES('Proctología');
    INSERT INTO Tipos_Areas VALUES('Psicología');
    INSERT INTO Tipos_Areas VALUES('Psiquiatría');
    INSERT INTO Tipos_Areas VALUES('Radiodiagnóstico o radiología');
    INSERT INTO Tipos_Areas VALUES('Rehabilitación');
    INSERT INTO Tipos_Areas VALUES('Reumatología');
    INSERT INTO Tipos_Areas VALUES('Toxicología');
    INSERT INTO Tipos_Areas VALUES('Traumatología y Ortopedia');
    INSERT INTO Tipos_Areas VALUES('Urología');

    INSERT INTO Tipos_Centros VALUES('Clínica');
	INSERT INTO Tipos_Centros VALUES('Consultorio');
	INSERT INTO Tipos_Centros VALUES('Hospital');
    INSERT INTO Tipos_Centros VALUES('Laboratorio');

	/* CAMBIAR Centro_Atencion POR Centros_Atencion */
    INSERT INTO Centros_Atencion VALUES(1, 'Hospital México', 'San José', 'San José', 'La Uruca', 'Transversal 74, San José, Costa Rica', 500, 'Hospital', 22426700);
	INSERT INTO Centros_Atencion VALUES(2, 'Hospital San Juan de Dios', 'San José', 'San José', 'Merced', 'Paseo Colón, Provincia de San José, San José, Costa Rica', 640, 'Hospital', 25478000);
	INSERT INTO Centros_Atencion VALUES(3, 'Hospital Rafael Ángel Calderón Guardia', 'San José', 'San Pedro', 'Los Yoses', 'entre las avenidas 17 y 19 y entre las calles 7 y 9.', 500, 'Hospital', 22121000);

	/* CAMBIAR POR VARCHAR(60) EN nombre_pais */
	INSERT INTO Paises VALUES('ABW', 'Aruba');
	INSERT INTO Paises VALUES('AFG', 'Afghanistan');
	INSERT INTO Paises VALUES('AGO', 'Angola');
	INSERT INTO Paises VALUES('AIA', 'Anguilla');
	INSERT INTO Paises VALUES('ALA', 'Åland Islands');
	INSERT INTO Paises VALUES('ALB', 'Albania');
	INSERT INTO Paises VALUES('AND', 'Andorra');
	INSERT INTO Paises VALUES('ARE', 'United Arab Emirates');
	INSERT INTO Paises VALUES('ARG', 'Argentina');
	INSERT INTO Paises VALUES('ARM', 'Armenia');
	INSERT INTO Paises VALUES('ASM', 'American Samoa');
	INSERT INTO Paises VALUES('ATA', 'Antarctica');
	INSERT INTO Paises VALUES('ATF', 'French Southern Territories');
	INSERT INTO Paises VALUES('ATG', 'Antigua and Barbuda');
	INSERT INTO Paises VALUES('AUS', 'Australia');
	INSERT INTO Paises VALUES('AUT', 'Austria');
	INSERT INTO Paises VALUES('AZE', 'Azerbaijan');
	INSERT INTO Paises VALUES('BDI', 'Burundi');
	INSERT INTO Paises VALUES('BEL', 'Belgium');
	INSERT INTO Paises VALUES('BEN', 'Benin');
	INSERT INTO Paises VALUES('BES', 'Bonaire, Sint Eustatius and Saba');
	INSERT INTO Paises VALUES('BFA', 'Burkina Faso');
	INSERT INTO Paises VALUES('BGD', 'Bangladesh');
	INSERT INTO Paises VALUES('BGR', 'Bulgaria');
	INSERT INTO Paises VALUES('BHR', 'Bahrain');
	INSERT INTO Paises VALUES('BHS', 'Bahamas');
	INSERT INTO Paises VALUES('BIH', 'Bosnia and Herzegovina');
	INSERT INTO Paises VALUES('BLM', 'Saint Barthélemy');
	INSERT INTO Paises VALUES('BLR', 'Belarus');
	INSERT INTO Paises VALUES('BLZ', 'Belize');
	INSERT INTO Paises VALUES('BMU', 'Bermuda');
	INSERT INTO Paises VALUES('BOL', 'Bolivia, Plurinational State of');
	INSERT INTO Paises VALUES('BRA', 'Brazil');
	INSERT INTO Paises VALUES('BRB', 'Barbados');
	INSERT INTO Paises VALUES('BRN', 'Brunei Darussalam');
	INSERT INTO Paises VALUES('BTN', 'Bhutan');
	INSERT INTO Paises VALUES('BVT', 'Bouvet Island');
	INSERT INTO Paises VALUES('BWA', 'Botswana');
	INSERT INTO Paises VALUES('CAF', 'Central African Republic');
	INSERT INTO Paises VALUES('CAN', 'Canada');
	INSERT INTO Paises VALUES('CCK', 'Cocos (Keeling) Islands');
	INSERT INTO Paises VALUES('CHE', 'Switzerland');
	INSERT INTO Paises VALUES('CHL', 'Chile');
	INSERT INTO Paises VALUES('CHN', 'China');
	INSERT INTO Paises VALUES('CIV', 'Côte d Ivoire');
	INSERT INTO Paises VALUES('CMR', 'Cameroon');
	INSERT INTO Paises VALUES('COD', 'Congo, the Democratic Republic of the');
	INSERT INTO Paises VALUES('COG', 'Congo');
	INSERT INTO Paises VALUES('COK', 'Cook Islands');
	INSERT INTO Paises VALUES('COL', 'Colombia');
	INSERT INTO Paises VALUES('COM', 'Comoros');
	INSERT INTO Paises VALUES('CPV', 'Cabo Verde');
	INSERT INTO Paises VALUES('CRI', 'Costa Rica');
	INSERT INTO Paises VALUES('CUB', 'Cuba');
	INSERT INTO Paises VALUES('CUW', 'Curaçao');
	INSERT INTO Paises VALUES('CXR', 'Christmas Island');
	INSERT INTO Paises VALUES('CYM', 'Cayman Islands');
	INSERT INTO Paises VALUES('CYP', 'Cyprus');
	INSERT INTO Paises VALUES('CZE', 'Czechia');
	INSERT INTO Paises VALUES('DEU', 'Germany');
	INSERT INTO Paises VALUES('DJI', 'Djibouti');
	INSERT INTO Paises VALUES('DMA', 'Dominica');
	INSERT INTO Paises VALUES('DNK', 'Denmark');
	INSERT INTO Paises VALUES('DOM', 'Dominican Republic');
	INSERT INTO Paises VALUES('DZA', 'Algeria');
	INSERT INTO Paises VALUES('ECU', 'Ecuador');
	INSERT INTO Paises VALUES('EGY', 'Egypt');
	INSERT INTO Paises VALUES('ERI', 'Eritrea');
	INSERT INTO Paises VALUES('ESH', 'Western Sahara');
	INSERT INTO Paises VALUES('ESP', 'Spain');
	INSERT INTO Paises VALUES('EST', 'Estonia');
	INSERT INTO Paises VALUES('ETH', 'Ethiopia');
	INSERT INTO Paises VALUES('FIN', 'Finland');
	INSERT INTO Paises VALUES('FJI', 'Fiji');
	INSERT INTO Paises VALUES('FLK', 'Falkland Islands (Malvinas)');
	INSERT INTO Paises VALUES('FRA', 'France');
	INSERT INTO Paises VALUES('FRO', 'Faroe Islands');
	INSERT INTO Paises VALUES('FSM', 'icronesia, Federated States of');
	INSERT INTO Paises VALUES('GAB', 'Gabon');
	INSERT INTO Paises VALUES('GBR', 'United Kingdom');
	INSERT INTO Paises VALUES('GEO', 'Georgia');
	INSERT INTO Paises VALUES('GGY', 'Guernsey');
	INSERT INTO Paises VALUES('GHA', 'Ghana');
	INSERT INTO Paises VALUES('GIB', 'Gibraltar');
	INSERT INTO Paises VALUES('GIN', 'Guinea');
	INSERT INTO Paises VALUES('GLP', 'Guadeloupe');
	INSERT INTO Paises VALUES('GMB', 'Gambia');
	INSERT INTO Paises VALUES('GNB', 'Guinea-Bissau');
	INSERT INTO Paises VALUES('GNQ', 'Equatorial Guinea');
	INSERT INTO Paises VALUES('GRC', 'Greece');
	INSERT INTO Paises VALUES('GRD', 'Grenada');
	INSERT INTO Paises VALUES('GRL', 'Greenland');
	INSERT INTO Paises VALUES('GTM', 'Guatemala');
	INSERT INTO Paises VALUES('GUF', 'French Guiana');
	INSERT INTO Paises VALUES('GUM', 'Guam');
	INSERT INTO Paises VALUES('GUY', 'Guyana');
	INSERT INTO Paises VALUES('HKG', 'Hong Kong');
	INSERT INTO Paises VALUES('HMD', 'Heard Island and McDonald Islands');
	INSERT INTO Paises VALUES('HND', 'Honduras');
	INSERT INTO Paises VALUES('HRV', 'Croatia');
	INSERT INTO Paises VALUES('HTI', 'Haiti');
	INSERT INTO Paises VALUES('HUN', 'Hungary');
	INSERT INTO Paises VALUES('IDN', 'Indonesia');
	INSERT INTO Paises VALUES('IMN', 'Isle of Man');
	INSERT INTO Paises VALUES('IND', 'India');
	INSERT INTO Paises VALUES('IOT', 'British Indian Ocean Territory');
	INSERT INTO Paises VALUES('IRL', 'Ireland');
	INSERT INTO Paises VALUES('IRN', 'Iran, Islamic Republic of');
	INSERT INTO Paises VALUES('IRQ', 'Iraq');
	INSERT INTO Paises VALUES('ISL', 'Iceland');
	INSERT INTO Paises VALUES('ISR', 'Israel');
	INSERT INTO Paises VALUES('ITA', 'Italy');
	INSERT INTO Paises VALUES('JAM', 'Jamaica');
	INSERT INTO Paises VALUES('JEY', 'Jersey');
	INSERT INTO Paises VALUES('JOR', 'Jordan');
	INSERT INTO Paises VALUES('JPN', 'Japan');
	INSERT INTO Paises VALUES('KAZ', 'Kazakhstan');
	INSERT INTO Paises VALUES('KEN', 'Kenya');
	INSERT INTO Paises VALUES('KGZ', 'Kyrgyzstan');
	INSERT INTO Paises VALUES('KHM', 'Cambodia');
	INSERT INTO Paises VALUES('KIR', 'Kiribati');
	INSERT INTO Paises VALUES('KNA', 'Saint Kitts and Nevis');
	INSERT INTO Paises VALUES('KOR', 'Korea, Republic of');
	INSERT INTO Paises VALUES('KWT', 'Kuwait');
	INSERT INTO Paises VALUES('LAO', 'Lao People s Democratic Republic');
	INSERT INTO Paises VALUES('LBN', 'Lebanon');
	INSERT INTO Paises VALUES('LBR', 'Liberia');
	INSERT INTO Paises VALUES('LBY', 'Libya');
	INSERT INTO Paises VALUES('LCA', 'Saint Lucia');
	INSERT INTO Paises VALUES('LIE', 'Liechtenstein');
	INSERT INTO Paises VALUES('LKA', 'Sri Lanka');
	INSERT INTO Paises VALUES('LSO', 'Lesotho');
	INSERT INTO Paises VALUES('LTU', 'Lithuania');
	INSERT INTO Paises VALUES('LUX', 'Luxembourg');
	INSERT INTO Paises VALUES('LVA', 'Latvia');
	INSERT INTO Paises VALUES('MAC', 'Macao');
	INSERT INTO Paises VALUES('MAF', 'Saint Martin (French part)');
	INSERT INTO Paises VALUES('MAR', 'Morocco');
	INSERT INTO Paises VALUES('MCO', 'Monaco');
	INSERT INTO Paises VALUES('MDA', 'Moldova, Republic of');
	INSERT INTO Paises VALUES('MDG', 'Madagascar');
	INSERT INTO Paises VALUES('MDV', 'Maldives');
	INSERT INTO Paises VALUES('MEX', 'Mexico');
	INSERT INTO Paises VALUES('MHL', 'Marshall Islands');
	INSERT INTO Paises VALUES('MKD', 'Macedonia, the former Yugoslav Republic of');
	INSERT INTO Paises VALUES('MLI', 'Mali');
	INSERT INTO Paises VALUES('MLT', 'Malta');
	INSERT INTO Paises VALUES('MMR', 'Myanmar');
	INSERT INTO Paises VALUES('MNE', 'Montenegro');
	INSERT INTO Paises VALUES('MNG', 'Mongolia');
	INSERT INTO Paises VALUES('MNP', 'Northern Mariana Islands');
	INSERT INTO Paises VALUES('MOZ', 'Mozambique');
	INSERT INTO Paises VALUES('MRT', 'Mauritania');
	INSERT INTO Paises VALUES('MSR', 'Montserrat');
	INSERT INTO Paises VALUES('MTQ', 'Martinique');
	INSERT INTO Paises VALUES('MUS', 'Mauritius');
	INSERT INTO Paises VALUES('MWI', 'Malawi');
	INSERT INTO Paises VALUES('MYS', 'Malaysia');
	INSERT INTO Paises VALUES('MYT', 'Mayotte');
	INSERT INTO Paises VALUES('NAM', 'Namibia');
	INSERT INTO Paises VALUES('NCL', 'New Caledonia');
	INSERT INTO Paises VALUES('NER', 'Niger');
	INSERT INTO Paises VALUES('NFK', 'Norfolk Island');
	INSERT INTO Paises VALUES('NGA', 'Nigeria');
	INSERT INTO Paises VALUES('NIC', 'Nicaragua');
	INSERT INTO Paises VALUES('NIU', 'Niue');
	INSERT INTO Paises VALUES('NLD', 'Netherlands');
	INSERT INTO Paises VALUES('NOR', 'Norway');
	INSERT INTO Paises VALUES('NPL', 'Nepal');
	INSERT INTO Paises VALUES('NRU', 'Nauru');
	INSERT INTO Paises VALUES('NZL', 'New Zealand');
	INSERT INTO Paises VALUES('OMN', 'Oman');
	INSERT INTO Paises VALUES('PAK', 'Pakistan');
	INSERT INTO Paises VALUES('PAN', 'Panama');
	INSERT INTO Paises VALUES('PCN', 'Pitcairn');
	INSERT INTO Paises VALUES('PER', 'Peru');
	INSERT INTO Paises VALUES('PHL', 'Philippines');
	INSERT INTO Paises VALUES('PLW', 'Palau');
	INSERT INTO Paises VALUES('PNG', 'Papua New Guinea');
	INSERT INTO Paises VALUES('POL', 'Poland');
	INSERT INTO Paises VALUES('PRI', 'Puerto Rico');
	INSERT INTO Paises VALUES('PRK', 'Korea, Democratic People s Republic of');
	INSERT INTO Paises VALUES('PRT', 'Portugal');
	INSERT INTO Paises VALUES('PRY', 'Paraguay');
	INSERT INTO Paises VALUES('PSE', 'Palestine, State of');
	INSERT INTO Paises VALUES('PYF', 'French Polynesia');
	INSERT INTO Paises VALUES('QAT', 'Qatar');
	INSERT INTO Paises VALUES('REU', 'Réunion');
	INSERT INTO Paises VALUES('ROU', 'Romania');
	INSERT INTO Paises VALUES('RUS', 'Russian Federation');
	INSERT INTO Paises VALUES('RWA', 'Rwanda');
	INSERT INTO Paises VALUES('SAU', 'Saudi Arabia');
	INSERT INTO Paises VALUES('SDN', 'Sudan');
	INSERT INTO Paises VALUES('SEN', 'Senegal');
	INSERT INTO Paises VALUES('SGP', 'Singapore');
	INSERT INTO Paises VALUES('SGS', 'South Georgia and the South Sandwich Islands');
	INSERT INTO Paises VALUES('SHN', 'Saint Helena, Ascension and Tristan da Cunha');
	INSERT INTO Paises VALUES('SJM', 'Svalbard and Jan Mayen');
	INSERT INTO Paises VALUES('SLB', 'Solomon Islands');
	INSERT INTO Paises VALUES('SLE', 'Sierra Leone');
	INSERT INTO Paises VALUES('SLV', 'El Salvador');
	INSERT INTO Paises VALUES('SMR', 'San Marino');
	INSERT INTO Paises VALUES('SOM', 'Somalia');
	INSERT INTO Paises VALUES('SPM', 'Saint Pierre and Miquelon');
	INSERT INTO Paises VALUES('SRB', 'Serbia');
	INSERT INTO Paises VALUES('SSD', 'South Sudan');
	INSERT INTO Paises VALUES('STP', 'Sao Tome and Principe');
	INSERT INTO Paises VALUES('SUR', 'Suriname');
	INSERT INTO Paises VALUES('SVK', 'Slovakia');
	INSERT INTO Paises VALUES('SVN', 'Slovenia');
	INSERT INTO Paises VALUES('SWE', 'Sweden');
	INSERT INTO Paises VALUES('SWZ', 'Swaziland');
	INSERT INTO Paises VALUES('SXM', 'Sint Maarten (Dutch part)');
	INSERT INTO Paises VALUES('SYC', 'Seychelles');
	INSERT INTO Paises VALUES('SYR', 'Syrian Arab Republic');
	INSERT INTO Paises VALUES('TCA', 'Turks and Caicos Islands');
	INSERT INTO Paises VALUES('TCD', 'Chad');
	INSERT INTO Paises VALUES('TGO', 'Togo');
	INSERT INTO Paises VALUES('THA', 'Thailand');
	INSERT INTO Paises VALUES('TJK', 'Tajikistan');
	INSERT INTO Paises VALUES('TKL', 'Tokelau');
	INSERT INTO Paises VALUES('TKM', 'Turkmenistan');
	INSERT INTO Paises VALUES('TLS', 'Timor-Leste');
	INSERT INTO Paises VALUES('TON', 'Tonga');
	INSERT INTO Paises VALUES('TTO', 'Trinidad and Tobago');
	INSERT INTO Paises VALUES('TUN', 'Tunisia');
	INSERT INTO Paises VALUES('TUR', 'Turkey');
	INSERT INTO Paises VALUES('TUV', 'Tuvalu');
	INSERT INTO Paises VALUES('TWN', 'Taiwan, Province of China');
	INSERT INTO Paises VALUES('TZA', 'Tanzania, United Republic of');
	INSERT INTO Paises VALUES('UGA', 'Uganda');
	INSERT INTO Paises VALUES('UKR', 'Ukraine');
	INSERT INTO Paises VALUES('UMI', 'United States Minor Outlying Islands');
	INSERT INTO Paises VALUES('URY', 'Uruguay');
	INSERT INTO Paises VALUES('USA', 'United States of America');
	INSERT INTO Paises VALUES('UZB', 'Uzbekistan');
	INSERT INTO Paises VALUES('VAT', 'Holy See (Vatican City State)');
	INSERT INTO Paises VALUES('VCT', 'Saint Vincent and the Grenadines');
	INSERT INTO Paises VALUES('VEN', 'Venezuela, Bolivarian Republic of');
	INSERT INTO Paises VALUES('VGB', 'Virgin Islands, British');
	INSERT INTO Paises VALUES('VIR', 'Virgin Islands, U.S.');
	INSERT INTO Paises VALUES('VNM', 'Viet Nam');
	INSERT INTO Paises VALUES('VUT', 'Vanuatu');
	INSERT INTO Paises VALUES('WLF', 'Wallis and Futuna');
	INSERT INTO Paises VALUES('WSM', 'Samoa');
	INSERT INTO Paises VALUES('YEM', 'Yemen');
	INSERT INTO Paises VALUES('ZAF', 'South Africa');
	INSERT INTO Paises VALUES('ZMB', 'Zambia');
	INSERT INTO Paises VALUES('ZWE', 'Zimbabwe');
    
    INSERT INTO Personas VALUES (1,'Nombre','Apellido1','Apellido2','1998-12-12','O-','Naciounidense','contra');
    INSERT INTO Funcionarios VALUES (1,null,1,'Administracion','2014-01-01','Administrador de Sistemas');

	INSERT INTO Citas VALUES(1, 1, 1, 'Atender en', '2016-12-30', '18:00:00', null, 'ESPERA');