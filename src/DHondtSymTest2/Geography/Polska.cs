﻿using System.Collections.Generic;
using System.Linq;

namespace DHondtSymTest2.Geography
{
	public static class Polska
	{
		public readonly static Dictionary<Teryt, JednostkaTerytorialna> Powiaty = new List<JednostkaTerytorialna>
		{
			#region new JednostkaTerytorialna[]
			new JednostkaTerytorialna { Teryt = new Teryt("0201"), Nazwa = "bolesławiecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0202"), Nazwa = "dzierżoniowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0203"), Nazwa = "głogowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0204"), Nazwa = "górowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0205"), Nazwa = "jaworski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0206"), Nazwa = "jeleniogórski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0207"), Nazwa = "kamiennogórski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0208"), Nazwa = "kłodzki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0209"), Nazwa = "legnicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0210"), Nazwa = "lubański" },
			new JednostkaTerytorialna { Teryt = new Teryt("0211"), Nazwa = "lubiński" },
			new JednostkaTerytorialna { Teryt = new Teryt("0212"), Nazwa = "lwówecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0213"), Nazwa = "milicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0214"), Nazwa = "oleśnicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0215"), Nazwa = "oławski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0216"), Nazwa = "polkowicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0217"), Nazwa = "strzeliński" },
			new JednostkaTerytorialna { Teryt = new Teryt("0218"), Nazwa = "średzki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0219"), Nazwa = "świdnicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0220"), Nazwa = "trzebnicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0221"), Nazwa = "wałbrzyski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0222"), Nazwa = "wołowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0223"), Nazwa = "wrocławski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0224"), Nazwa = "ząbkowicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0225"), Nazwa = "zgorzelecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0226"), Nazwa = "złotoryjski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0261"), Nazwa = "Jelenia Góra" },
			new JednostkaTerytorialna { Teryt = new Teryt("0262"), Nazwa = "Legnica" },
			new JednostkaTerytorialna { Teryt = new Teryt("0264"), Nazwa = "Wrocław" },
			new JednostkaTerytorialna { Teryt = new Teryt("0265"), Nazwa = "Wałbrzych" },
			new JednostkaTerytorialna { Teryt = new Teryt("0401"), Nazwa = "aleksandrowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0402"), Nazwa = "brodnicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0403"), Nazwa = "bydgoski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0404"), Nazwa = "chełmiński" },
			new JednostkaTerytorialna { Teryt = new Teryt("0405"), Nazwa = "golubsko-dobrzyński" },
			new JednostkaTerytorialna { Teryt = new Teryt("0406"), Nazwa = "grudziądzki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0407"), Nazwa = "inowrocławski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0408"), Nazwa = "lipnowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0409"), Nazwa = "mogileński" },
			new JednostkaTerytorialna { Teryt = new Teryt("0410"), Nazwa = "nakielski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0411"), Nazwa = "radziejowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0412"), Nazwa = "rypiński" },
			new JednostkaTerytorialna { Teryt = new Teryt("0413"), Nazwa = "sępoleński" },
			new JednostkaTerytorialna { Teryt = new Teryt("0414"), Nazwa = "świecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0415"), Nazwa = "toruński" },
			new JednostkaTerytorialna { Teryt = new Teryt("0416"), Nazwa = "tucholski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0417"), Nazwa = "wąbrzeski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0418"), Nazwa = "włocławski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0419"), Nazwa = "żniński" },
			new JednostkaTerytorialna { Teryt = new Teryt("0461"), Nazwa = "Bydgoszcz" },
			new JednostkaTerytorialna { Teryt = new Teryt("0462"), Nazwa = "Grudziądz" },
			new JednostkaTerytorialna { Teryt = new Teryt("0463"), Nazwa = "Toruń" },
			new JednostkaTerytorialna { Teryt = new Teryt("0464"), Nazwa = "Włocławek" },
			new JednostkaTerytorialna { Teryt = new Teryt("0601"), Nazwa = "bialski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0602"), Nazwa = "biłgorajski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0603"), Nazwa = "chełmski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0604"), Nazwa = "hrubieszowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0605"), Nazwa = "janowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0606"), Nazwa = "krasnostawski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0607"), Nazwa = "kraśnicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0608"), Nazwa = "lubartowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0609"), Nazwa = "lubelski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0610"), Nazwa = "łęczyński" },
			new JednostkaTerytorialna { Teryt = new Teryt("0611"), Nazwa = "łukowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0612"), Nazwa = "opolski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0613"), Nazwa = "parczewski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0614"), Nazwa = "puławski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0615"), Nazwa = "radzyński" },
			new JednostkaTerytorialna { Teryt = new Teryt("0616"), Nazwa = "rycki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0617"), Nazwa = "świdnicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0618"), Nazwa = "tomaszowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0619"), Nazwa = "włodawski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0620"), Nazwa = "zamojski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0661"), Nazwa = "Biała Podlaska" },
			new JednostkaTerytorialna { Teryt = new Teryt("0662"), Nazwa = "Chełm" },
			new JednostkaTerytorialna { Teryt = new Teryt("0663"), Nazwa = "Lublin" },
			new JednostkaTerytorialna { Teryt = new Teryt("0664"), Nazwa = "Zamość" },
			new JednostkaTerytorialna { Teryt = new Teryt("0801"), Nazwa = "gorzowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0802"), Nazwa = "krośnieński" },
			new JednostkaTerytorialna { Teryt = new Teryt("0803"), Nazwa = "międzyrzecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0804"), Nazwa = "nowosolski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0805"), Nazwa = "słubicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0806"), Nazwa = "strzelecko-drezdenecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("0807"), Nazwa = "sulęciński" },
			new JednostkaTerytorialna { Teryt = new Teryt("0808"), Nazwa = "świebodziński" },
			new JednostkaTerytorialna { Teryt = new Teryt("0809"), Nazwa = "zielonogórski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0810"), Nazwa = "żagański" },
			new JednostkaTerytorialna { Teryt = new Teryt("0811"), Nazwa = "żarski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0812"), Nazwa = "wschowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0861"), Nazwa = "Gorzów Wielkopolski" },
			new JednostkaTerytorialna { Teryt = new Teryt("0862"), Nazwa = "Zielona Góra" },
			new JednostkaTerytorialna { Teryt = new Teryt("1001"), Nazwa = "bełchatowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1002"), Nazwa = "kutnowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1003"), Nazwa = "łaski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1004"), Nazwa = "łęczycki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1005"), Nazwa = "łowicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1006"), Nazwa = "łódzki wschodni" },
			new JednostkaTerytorialna { Teryt = new Teryt("1007"), Nazwa = "opoczyński" },
			new JednostkaTerytorialna { Teryt = new Teryt("1008"), Nazwa = "pabianicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1009"), Nazwa = "pajęczański" },
			new JednostkaTerytorialna { Teryt = new Teryt("1010"), Nazwa = "piotrkowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1011"), Nazwa = "poddębicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1012"), Nazwa = "radomszczański" },
			new JednostkaTerytorialna { Teryt = new Teryt("1013"), Nazwa = "rawski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1014"), Nazwa = "sieradzki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1015"), Nazwa = "skierniewicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1016"), Nazwa = "tomaszowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1017"), Nazwa = "wieluński" },
			new JednostkaTerytorialna { Teryt = new Teryt("1018"), Nazwa = "wieruszowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1019"), Nazwa = "zduńskowolski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1020"), Nazwa = "zgierski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1021"), Nazwa = "brzeziński" },
			new JednostkaTerytorialna { Teryt = new Teryt("1061"), Nazwa = "Łódź" },
			new JednostkaTerytorialna { Teryt = new Teryt("1062"), Nazwa = "Piotrków Trybunalski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1063"), Nazwa = "Skierniewice" },
			new JednostkaTerytorialna { Teryt = new Teryt("1201"), Nazwa = "bocheński" },
			new JednostkaTerytorialna { Teryt = new Teryt("1202"), Nazwa = "brzeski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1203"), Nazwa = "chrzanowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1204"), Nazwa = "dąbrowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1205"), Nazwa = "gorlicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1206"), Nazwa = "krakowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1207"), Nazwa = "limanowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1208"), Nazwa = "miechowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1209"), Nazwa = "myślenicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1210"), Nazwa = "nowosądecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1211"), Nazwa = "nowotarski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1212"), Nazwa = "olkuski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1213"), Nazwa = "oświęcimski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1214"), Nazwa = "proszowicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1215"), Nazwa = "suski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1216"), Nazwa = "tarnowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1217"), Nazwa = "tatrzański" },
			new JednostkaTerytorialna { Teryt = new Teryt("1218"), Nazwa = "wadowicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1219"), Nazwa = "wielicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1261"), Nazwa = "Kraków" },
			new JednostkaTerytorialna { Teryt = new Teryt("1262"), Nazwa = "Nowy Sącz" },
			new JednostkaTerytorialna { Teryt = new Teryt("1263"), Nazwa = "Tarnów" },
			new JednostkaTerytorialna { Teryt = new Teryt("1401"), Nazwa = "białobrzeski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1402"), Nazwa = "ciechanowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1403"), Nazwa = "garwoliński" },
			new JednostkaTerytorialna { Teryt = new Teryt("1404"), Nazwa = "gostyniński" },
			new JednostkaTerytorialna { Teryt = new Teryt("1405"), Nazwa = "grodziski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1406"), Nazwa = "grójecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1407"), Nazwa = "kozienicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1408"), Nazwa = "legionowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1409"), Nazwa = "lipski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1410"), Nazwa = "łosicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1411"), Nazwa = "makowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1412"), Nazwa = "miński" },
			new JednostkaTerytorialna { Teryt = new Teryt("1413"), Nazwa = "mławski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1414"), Nazwa = "nowodworski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1415"), Nazwa = "ostrołęcki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1416"), Nazwa = "ostrowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1417"), Nazwa = "otwocki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1418"), Nazwa = "piaseczyński" },
			new JednostkaTerytorialna { Teryt = new Teryt("1419"), Nazwa = "płocki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1420"), Nazwa = "płoński" },
			new JednostkaTerytorialna { Teryt = new Teryt("1421"), Nazwa = "pruszkowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1422"), Nazwa = "przasnyski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1423"), Nazwa = "przysuski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1424"), Nazwa = "pułtuski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1425"), Nazwa = "radomski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1426"), Nazwa = "siedlecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1427"), Nazwa = "sierpecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1428"), Nazwa = "sochaczewski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1429"), Nazwa = "sokołowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1430"), Nazwa = "szydłowiecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1432"), Nazwa = "warszawski zachodni" },
			new JednostkaTerytorialna { Teryt = new Teryt("1433"), Nazwa = "węgrowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1434"), Nazwa = "wołomiński" },
			new JednostkaTerytorialna { Teryt = new Teryt("1435"), Nazwa = "wyszkowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1436"), Nazwa = "zwoleński" },
			new JednostkaTerytorialna { Teryt = new Teryt("1437"), Nazwa = "żuromiński" },
			new JednostkaTerytorialna { Teryt = new Teryt("1438"), Nazwa = "żyrardowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1461"), Nazwa = "Ostrołęka" },
			new JednostkaTerytorialna { Teryt = new Teryt("1462"), Nazwa = "Płock" },
			new JednostkaTerytorialna { Teryt = new Teryt("1463"), Nazwa = "Radom" },
			new JednostkaTerytorialna { Teryt = new Teryt("1464"), Nazwa = "Siedlce" },
			new JednostkaTerytorialna { Teryt = new Teryt("1465"), Nazwa = "Warszawa" },
			new JednostkaTerytorialna { Teryt = new Teryt("1601"), Nazwa = "brzeski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1602"), Nazwa = "głubczycki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1603"), Nazwa = "kędzierzyńsko-kozielski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1604"), Nazwa = "kluczborski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1605"), Nazwa = "krapkowicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1606"), Nazwa = "namysłowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1607"), Nazwa = "nyski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1608"), Nazwa = "oleski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1609"), Nazwa = "opolski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1610"), Nazwa = "prudnicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1611"), Nazwa = "strzelecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1661"), Nazwa = "Opole" },
			new JednostkaTerytorialna { Teryt = new Teryt("1801"), Nazwa = "bieszczadzki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1802"), Nazwa = "brzozowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1803"), Nazwa = "dębicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1804"), Nazwa = "jarosławski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1805"), Nazwa = "jasielski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1806"), Nazwa = "kolbuszowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1807"), Nazwa = "krośnieński" },
			new JednostkaTerytorialna { Teryt = new Teryt("1808"), Nazwa = "leżajski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1809"), Nazwa = "lubaczowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1810"), Nazwa = "łańcucki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1811"), Nazwa = "mielecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1812"), Nazwa = "niżański" },
			new JednostkaTerytorialna { Teryt = new Teryt("1813"), Nazwa = "przemyski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1814"), Nazwa = "przeworski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1815"), Nazwa = "ropczycko-sędziszowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1816"), Nazwa = "rzeszowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1817"), Nazwa = "sanocki" },
			new JednostkaTerytorialna { Teryt = new Teryt("1818"), Nazwa = "stalowowolski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1819"), Nazwa = "strzyżowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1820"), Nazwa = "tarnobrzeski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1821"), Nazwa = "leski" },
			new JednostkaTerytorialna { Teryt = new Teryt("1861"), Nazwa = "Krosno" },
			new JednostkaTerytorialna { Teryt = new Teryt("1862"), Nazwa = "Przemyśl" },
			new JednostkaTerytorialna { Teryt = new Teryt("1863"), Nazwa = "Rzeszów" },
			new JednostkaTerytorialna { Teryt = new Teryt("1864"), Nazwa = "Tarnobrzeg" },
			new JednostkaTerytorialna { Teryt = new Teryt("2001"), Nazwa = "augustowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2002"), Nazwa = "białostocki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2003"), Nazwa = "bielski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2004"), Nazwa = "grajewski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2005"), Nazwa = "hajnowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2006"), Nazwa = "kolneński" },
			new JednostkaTerytorialna { Teryt = new Teryt("2007"), Nazwa = "łomżyński" },
			new JednostkaTerytorialna { Teryt = new Teryt("2008"), Nazwa = "moniecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2009"), Nazwa = "sejneński" },
			new JednostkaTerytorialna { Teryt = new Teryt("2010"), Nazwa = "siemiatycki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2011"), Nazwa = "sokólski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2012"), Nazwa = "suwalski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2013"), Nazwa = "wysokomazowiecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2014"), Nazwa = "zambrowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2061"), Nazwa = "Białystok" },
			new JednostkaTerytorialna { Teryt = new Teryt("2062"), Nazwa = "Łomża" },
			new JednostkaTerytorialna { Teryt = new Teryt("2063"), Nazwa = "Suwałki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2201"), Nazwa = "bytowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2202"), Nazwa = "chojnicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2203"), Nazwa = "człuchowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2204"), Nazwa = "gdański" },
			new JednostkaTerytorialna { Teryt = new Teryt("2205"), Nazwa = "kartuski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2206"), Nazwa = "kościerski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2207"), Nazwa = "kwidzyński" },
			new JednostkaTerytorialna { Teryt = new Teryt("2208"), Nazwa = "lęborski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2209"), Nazwa = "malborski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2210"), Nazwa = "nowodworski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2211"), Nazwa = "pucki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2212"), Nazwa = "słupski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2213"), Nazwa = "starogardzki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2214"), Nazwa = "tczewski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2215"), Nazwa = "wejherowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2216"), Nazwa = "sztumski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2261"), Nazwa = "Gdańsk" },
			new JednostkaTerytorialna { Teryt = new Teryt("2262"), Nazwa = "Gdynia" },
			new JednostkaTerytorialna { Teryt = new Teryt("2263"), Nazwa = "Słupsk" },
			new JednostkaTerytorialna { Teryt = new Teryt("2264"), Nazwa = "Sopot" },
			new JednostkaTerytorialna { Teryt = new Teryt("2401"), Nazwa = "będziński" },
			new JednostkaTerytorialna { Teryt = new Teryt("2402"), Nazwa = "bielski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2403"), Nazwa = "cieszyński" },
			new JednostkaTerytorialna { Teryt = new Teryt("2404"), Nazwa = "częstochowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2405"), Nazwa = "gliwicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2406"), Nazwa = "kłobucki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2407"), Nazwa = "lubliniecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2408"), Nazwa = "mikołowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2409"), Nazwa = "myszkowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2410"), Nazwa = "pszczyński" },
			new JednostkaTerytorialna { Teryt = new Teryt("2411"), Nazwa = "raciborski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2412"), Nazwa = "rybnicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2413"), Nazwa = "tarnogórski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2414"), Nazwa = "bieruńsko-lędziński" },
			new JednostkaTerytorialna { Teryt = new Teryt("2415"), Nazwa = "wodzisławski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2416"), Nazwa = "zawierciański" },
			new JednostkaTerytorialna { Teryt = new Teryt("2417"), Nazwa = "żywiecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2461"), Nazwa = "Bielsko-Biała" },
			new JednostkaTerytorialna { Teryt = new Teryt("2462"), Nazwa = "Bytom" },
			new JednostkaTerytorialna { Teryt = new Teryt("2463"), Nazwa = "Chorzów" },
			new JednostkaTerytorialna { Teryt = new Teryt("2464"), Nazwa = "Częstochowa" },
			new JednostkaTerytorialna { Teryt = new Teryt("2465"), Nazwa = "Dąbrowa Górnicza" },
			new JednostkaTerytorialna { Teryt = new Teryt("2466"), Nazwa = "Gliwice" },
			new JednostkaTerytorialna { Teryt = new Teryt("2467"), Nazwa = "Jastrzębie-Zdrój" },
			new JednostkaTerytorialna { Teryt = new Teryt("2468"), Nazwa = "Jaworzno" },
			new JednostkaTerytorialna { Teryt = new Teryt("2469"), Nazwa = "Katowice" },
			new JednostkaTerytorialna { Teryt = new Teryt("2470"), Nazwa = "Mysłowice" },
			new JednostkaTerytorialna { Teryt = new Teryt("2471"), Nazwa = "Piekary Śląskie" },
			new JednostkaTerytorialna { Teryt = new Teryt("2472"), Nazwa = "Ruda Śląska" },
			new JednostkaTerytorialna { Teryt = new Teryt("2473"), Nazwa = "Rybnik" },
			new JednostkaTerytorialna { Teryt = new Teryt("2474"), Nazwa = "Siemianowice Śląskie" },
			new JednostkaTerytorialna { Teryt = new Teryt("2475"), Nazwa = "Sosnowiec" },
			new JednostkaTerytorialna { Teryt = new Teryt("2476"), Nazwa = "Świętochłowice" },
			new JednostkaTerytorialna { Teryt = new Teryt("2477"), Nazwa = "Tychy" },
			new JednostkaTerytorialna { Teryt = new Teryt("2478"), Nazwa = "Zabrze" },
			new JednostkaTerytorialna { Teryt = new Teryt("2479"), Nazwa = "Żory" },
			new JednostkaTerytorialna { Teryt = new Teryt("2601"), Nazwa = "buski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2602"), Nazwa = "jędrzejowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2603"), Nazwa = "kazimierski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2604"), Nazwa = "kielecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2605"), Nazwa = "konecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2606"), Nazwa = "opatowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2607"), Nazwa = "ostrowiecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2608"), Nazwa = "pińczowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2609"), Nazwa = "sandomierski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2610"), Nazwa = "skarżyski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2611"), Nazwa = "starachowicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2612"), Nazwa = "staszowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2613"), Nazwa = "włoszczowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2661"), Nazwa = "Kielce" },
			new JednostkaTerytorialna { Teryt = new Teryt("2801"), Nazwa = "bartoszycki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2802"), Nazwa = "braniewski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2803"), Nazwa = "działdowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2804"), Nazwa = "elbląski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2805"), Nazwa = "ełcki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2806"), Nazwa = "giżycki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2807"), Nazwa = "iławski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2808"), Nazwa = "kętrzyński" },
			new JednostkaTerytorialna { Teryt = new Teryt("2809"), Nazwa = "lidzbarski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2810"), Nazwa = "mrągowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2811"), Nazwa = "nidzicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2812"), Nazwa = "nowomiejski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2813"), Nazwa = "olecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2814"), Nazwa = "olsztyński" },
			new JednostkaTerytorialna { Teryt = new Teryt("2815"), Nazwa = "ostródzki" },
			new JednostkaTerytorialna { Teryt = new Teryt("2816"), Nazwa = "piski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2817"), Nazwa = "szczycieński" },
			new JednostkaTerytorialna { Teryt = new Teryt("2818"), Nazwa = "gołdapski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2819"), Nazwa = "węgorzewski" },
			new JednostkaTerytorialna { Teryt = new Teryt("2861"), Nazwa = "Elbląg" },
			new JednostkaTerytorialna { Teryt = new Teryt("2862"), Nazwa = "Olsztyn" },
			new JednostkaTerytorialna { Teryt = new Teryt("3001"), Nazwa = "chodzieski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3002"), Nazwa = "czarnkowsko-trzcianecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("3003"), Nazwa = "gnieźnieński" },
			new JednostkaTerytorialna { Teryt = new Teryt("3004"), Nazwa = "gostyński" },
			new JednostkaTerytorialna { Teryt = new Teryt("3005"), Nazwa = "grodziski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3006"), Nazwa = "jarociński" },
			new JednostkaTerytorialna { Teryt = new Teryt("3007"), Nazwa = "kaliski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3008"), Nazwa = "kępiński" },
			new JednostkaTerytorialna { Teryt = new Teryt("3009"), Nazwa = "kolski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3010"), Nazwa = "koniński" },
			new JednostkaTerytorialna { Teryt = new Teryt("3011"), Nazwa = "kościański" },
			new JednostkaTerytorialna { Teryt = new Teryt("3012"), Nazwa = "krotoszyński" },
			new JednostkaTerytorialna { Teryt = new Teryt("3013"), Nazwa = "leszczyński" },
			new JednostkaTerytorialna { Teryt = new Teryt("3014"), Nazwa = "międzychodzki" },
			new JednostkaTerytorialna { Teryt = new Teryt("3015"), Nazwa = "nowotomyski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3016"), Nazwa = "obornicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("3017"), Nazwa = "ostrowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3018"), Nazwa = "ostrzeszowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3019"), Nazwa = "pilski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3020"), Nazwa = "pleszewski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3021"), Nazwa = "poznański" },
			new JednostkaTerytorialna { Teryt = new Teryt("3022"), Nazwa = "rawicki" },
			new JednostkaTerytorialna { Teryt = new Teryt("3023"), Nazwa = "słupecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("3024"), Nazwa = "szamotulski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3025"), Nazwa = "średzki" },
			new JednostkaTerytorialna { Teryt = new Teryt("3026"), Nazwa = "śremski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3027"), Nazwa = "turecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("3028"), Nazwa = "wągrowiecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("3029"), Nazwa = "wolsztyński" },
			new JednostkaTerytorialna { Teryt = new Teryt("3030"), Nazwa = "wrzesiński" },
			new JednostkaTerytorialna { Teryt = new Teryt("3031"), Nazwa = "złotowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3061"), Nazwa = "Kalisz" },
			new JednostkaTerytorialna { Teryt = new Teryt("3062"), Nazwa = "Konin" },
			new JednostkaTerytorialna { Teryt = new Teryt("3063"), Nazwa = "Leszno" },
			new JednostkaTerytorialna { Teryt = new Teryt("3064"), Nazwa = "Poznań" },
			new JednostkaTerytorialna { Teryt = new Teryt("3201"), Nazwa = "białogardzki" },
			new JednostkaTerytorialna { Teryt = new Teryt("3202"), Nazwa = "choszczeński" },
			new JednostkaTerytorialna { Teryt = new Teryt("3203"), Nazwa = "drawski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3204"), Nazwa = "goleniowski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3205"), Nazwa = "gryficki" },
			new JednostkaTerytorialna { Teryt = new Teryt("3206"), Nazwa = "gryfiński" },
			new JednostkaTerytorialna { Teryt = new Teryt("3207"), Nazwa = "kamieński" },
			new JednostkaTerytorialna { Teryt = new Teryt("3208"), Nazwa = "kołobrzeski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3209"), Nazwa = "koszaliński" },
			new JednostkaTerytorialna { Teryt = new Teryt("3210"), Nazwa = "myśliborski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3211"), Nazwa = "policki" },
			new JednostkaTerytorialna { Teryt = new Teryt("3212"), Nazwa = "pyrzycki" },
			new JednostkaTerytorialna { Teryt = new Teryt("3213"), Nazwa = "sławieński" },
			new JednostkaTerytorialna { Teryt = new Teryt("3214"), Nazwa = "stargardzki" },
			new JednostkaTerytorialna { Teryt = new Teryt("3215"), Nazwa = "szczecinecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("3216"), Nazwa = "świdwiński" },
			new JednostkaTerytorialna { Teryt = new Teryt("3217"), Nazwa = "wałecki" },
			new JednostkaTerytorialna { Teryt = new Teryt("3218"), Nazwa = "łobeski" },
			new JednostkaTerytorialna { Teryt = new Teryt("3261"), Nazwa = "Koszalin" },
			new JednostkaTerytorialna { Teryt = new Teryt("3262"), Nazwa = "Szczecin" },
			new JednostkaTerytorialna { Teryt = new Teryt("3263"), Nazwa = "Świnoujście" },
			#endregion
		}
		.ToDictionary(j => j.Teryt);
	}
}