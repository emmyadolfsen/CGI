# CGI
Programmeringsuppgift intervju

Uppgiften gick ut på att skapa ett Web API där man kan få ut de 10 mest frekventa orden i en textmassa ihop med frekvensen.

## Konstruktion
Jag använde mig av VS Code och .NET 5 med C# och MVC för uppgiften och utförde följande steg:
- Startade nytt project med kommandot "dotnet new mvc"
- skapade en modellklass med två properties: "TextInput" och "WordCount"
- skapade en actionmetod i "HomeController" med POST där jag skickade med input från ett formulär
- i metoden:
    - gör jag om bokstäverna till lowercase ```ToLower()``` och plockar ut orden ur textinputen med ```Split()```
    - loopar orden i en foreach för att, med LINQ, räkna hur många ggr de förekommer ```int count = list.Where(temp => temp.Equals(word)).Select(temp => temp).Count();```
    - sorterar i fallande ordning ```OrderBy()```
    - gör om listan till Hashset för att få endast unika objekt
    - lägger in som en lista i en ViewBag
- Modifierade vyn i View/Home/Index där jag la in ett formulär och en utskrift via en for-loop och ViewBag av den inlagda texten som fått gå genom controllern.

Jag testkörde främst genom "Run without debugging" där min browser automatiskt öppnades och jag kunde testa att lägga in olika texter som vid submit skrevs ut i en lista med de 10 mest frekventa orden. 


## Start Debugging
Jag hoppas jag har förstått uppgiften rätt :sweat_smile: