Egy autósiskola tanulóinak adatait fix formátumú .csv fájlokban vannak tárolva.
Ezek első sora a fejléc.
A .csv fájlt beolvassuk és lehetővé teszem a felhasználónak ezek szerkesztését.
Emellett néhány attribútumra (pl. email cím, stb.) formátum-ellenőrzést állítottam be egyes property-k setter ágában.
A kategóriák fix jelöléssel vannak megnevezve (B-autó, A-motor, stb.), így ezeket enumerációval kezelem.
Az alkalmazásban is megjelenő adatok közül a kiválasztott tanulók adatait egy formázott Excel munkafüzetbe exportálom.
Egy minta .csv fájt a projekt gyökérmappájába elhelyeztem.