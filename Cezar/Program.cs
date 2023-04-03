// szyfr cezara:
// przestaw do przodu o (np.) 3 litery:
// A->D, E->G, ...

string ToAsciiCaesar(string clearText, int key)
{
	//zamień wszystkie litery na wielkie
	clearText = clearText.ToUpper();
	//zmienna na zaszyfrowany tekst
	string encryptedText = "";
	//dla każdej litery w tekście...
	foreach (char c in clearText)
	{
		//rzutujemy literę na jej kod ascii
		int asciiCode = (int)c;
		//dodajemy wartość przesunięcia (klucz)
		asciiCode += key;
		//jeśli wyjdziemy poza zakres...
		if(asciiCode > 90)
		{
			asciiCode -= 26;
		}
		//konwerstujemy z powrotem na literę i zapisujemy do szyfrowanego tekstu
		encryptedText += (char)asciiCode;
	}
	return encryptedText;
}
string FromAsciiCaesar(string encryptedText, int key)
{
    //zmienna na odszyfrowany tekst
    string clearText = "";
    //dla każdej litery w tekście...
    foreach (char c in encryptedText)
    {
        //rzutujemy literę na jej kod ascii
        int asciiCode = (int)c;
        //dodajemy wartość przesunięcia (klucz)
        asciiCode -= key;
        //jeśli wyjdziemy poza zakres...
        if (asciiCode < 65 && asciiCode != 32)
        {
            asciiCode += 26;
        }
        //konwerstujemy z powrotem na literę i zapisujemy do szyfrowanego tekstu
        clearText += (char)asciiCode;
    }
    return clearText;
}
string text = "TEKST DO ZASZYFROWANIA";
string cypher = ToAsciiCaesar(text, 3);
Console.WriteLine("Zaszyfrowany tekst: " + cypher);

text = FromAsciiCaesar(cypher, 3);
Console.WriteLine("Odszyfrowany tekst: " + text);