

/*
FONTOS!!!
- Külső fáljban nem adjuk meg a <script><!script> címkét
- Kis és nagybetű közt különbség van
- Pontos vesszővel zárjuk le az utastásokat

*/

document.write("Hello World!");

//szövegben alkalmazhatunk HTML formázást is.
document.write("<b>Hello</b> World!<br>")

//Aposztrófjelek elhagyása
document.write('1 + 1 = ', 1 + 1, '<br>')

//VÁLTOZÓK 
/*
- Addig örzi meg a tartalmát, amíg felül nem írjuk.
- Az értékadással azt is megmondjuk, hogy milyen típusú adatot kívánunk tárolni.
*/

var kutya = 101;
document.write(kutya, '<br>')
document.write(kutya-1, '<br>' )
document.write((kutya-1)*2, '<br>' )

//Három elemi addattípus: szám, szöveg, logikai
var a = 3;
var b = 2.5;
document.write('T = ', a * b, ' cm<sup>2</sup> <br>')
var c = 'alma';
var d = 'fa';
document.write('Két string konkanációja: ', c + d, '<br>');

var f = false 
document.write('Logikai változó: ', f, ' és ellentettje: ', !f, '<br>')


/*
VEZÉRLÉSI SZERKEZETEK
- szekvencia: utasítások egymás utánivégrehajtás
- szelekció: feltételes elágazás
- iteráció: ciklus
*/

//Döntsük el egy számról, hogy páros vagy páratlan!
var szam = 12;
if(szam % 2 == 0)
{
    document.write(szam, 'A szám páros <br>')
}
else
{
    document.write(szam ,'A szám páratlan <br>')
}

//prompt utasítás: futási időben kérhetünk be a felhasználótól adatot

var b = prompt('Kérek egy számot: ')
/*
if(b % 2 == 0)
{
    document.write(b, 'A szám páros <br>')
}
else
{
    document.write(b, 'A szám páratlan <br>')
}*/

//isFinite () - logikai igaz értéket ad vissza, ha a paramétere szám típusú

if (isFinite(b))
{
    if(b % 2 == 0)
    {
        document.write('A ',b, ' szám páros <br>')
    }
    else
    {
        document.write('A ',b, ' szám páratlan <br>')
    }
}
else{
    document.write(b, ' AZ NEM SZÁM! <br>');
}
//Matematikai függvény
//Math.floor() függvény: a paraméterként kapott szám egészrészét adja vissza

var d = prompt('d =', '0');
if(isFinite(d)) //szám-e
{
    if(Math.floor(d) == d) //egész szám-e
    {
        if (d % 2 == 0)
        {
           document.write(d, 'páros <br>')
            
        }
        else
        {
            document.write(d, 'páratlan <br>');
        }
    }
    else
    {
        document.write(d, ' nem egész szám <br>');
    }
}
else
    {
        document.write(d, ' Nem szám <br>');
    }

//Kérjük be a felhasználótól egy 100-nál nagyobb páros számot!

var e = prompt('e = ', 'Adjon meg 100-nál nagyobb páros számot');
if (e % 2 == 0 && e > 100)
{
    document.write('OK <br>')
}
else
{
    document.write('ABERÁLT \n')
}

//Kérjük be 2-vel vagy 7-tel osztható 100-nál nagyobb szám!

var n1 = prompt('n1= ', '2vel/7-tel/>100')

if(n1 > 100 && (n1%2 ==0 || n1 % 7 ==0 ))
{
    document.write('ÜGYEEEEEEEEEEEES <br>')
}
else
{
    document.write('NONO DUMB FUCK <br>')
}

var a = prompt('a = ',)
var b = prompt('b = ',)
var c = prompt('c = ',)

if (a + b > c && a + c > b && c + b > a)
{
 document.write("LET'S GOOOOOOOOOO")
}
else
{
    document.write('ABERÁLLLLLLLLLLLLLLLLLLLLLLLLT')
}



