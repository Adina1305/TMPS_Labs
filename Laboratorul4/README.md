Pîntea Adina, TI-202
Lucrarea de Laboraqtor nr. 4
Tema: Behavioral Design Patterns.

Obiective: 
1.	Studiați și înțelegeți modelele de design comportamental.
2.	Ca o continuare a lucrărilor anterioare de laborator, gândiți-vă la ce comunicare între entitățile software ar putea fi implicată în sistemul dumneavoastră.
3.	Creați un proiect nou sau adăugați câteva funcționalități suplimentare folosind modele de design comportamental.

Noțiuni teoretice:
Modelele de design comportamental sunt o categorie de modele de design care se concentrează pe interacțiunea și comunicarea dintre obiecte și clase. Ele oferă o modalitate de a organiza comportamentul obiectelor într-un mod flexibil și reutilizabil, separând în același timp responsabilitățile obiectelor de detaliile specifice de implementare. Tiparele de design comportamental abordează probleme comune întâlnite în comportamentul obiectelor, cum ar fi modul de definire a interacțiunilor dintre obiecte, modul de control al fluxului de mesaje între obiecte sau modul de definire a algoritmilor și politicilor care pot fi reutilizate în diferite obiecte și clase.
    Câteva exemple din această categorie de modele de design sunt:
•	Chain of Responsibility
•	Command
•	Interpreter
•	Iterator
•	Mediator
•	Observer
•	Strategy

Noțiunile Șabloanelor Comportamentale și exemple de utilizare:
1.	Chain of Responsibility (Lanțul responsabilității): 
•	Definiție: Acest șablon permite mai multor obiecte să încerce să rezolve o problemă, dar într-o anumită ordine, până când unul dintre ele o rezolvă. 
•	Exemplu: Într-un sistem de ticketing pentru suportul clienților, mai mulți agenți pot încerca să rezolve problema unui client, dar în cazul în care nu reușesc, problema este trimisă mai departe către nivelul superior al departamentului de suport. 
2.	Command (Comandă): 
•	Definiție: Acest șablon permite encapsularea unei cereri intr-un obiect, ceea ce face posibilă parametrizarea clienților cu diferite cereri, coadă sau înregistrare de comenzi și suport pentru anularea operațiilor. 
•	Exemplu: O aplicație care permite utilizatorilor să creeze liste de sarcini poate utiliza acest șablon pentru a permite utilizatorilor să adauge, să șteargă sau să marcheze sarcini ca fiind finalizate, cu ajutorul comenzilor. 
3.	Interpreter (Interpretor): 
•	Definiție: Acest șablon permite interpretarea și evaluarea expresiilor gramaticale sau a sintaxelor unei limbaje specifice, prin intermediul unui interpretor. 
•	Exemplu: Un motor de căutare care oferă o funcționalitate de căutare avansată poate utiliza acest șablon pentru a permite utilizatorilor să specifice interogări complexe cu ajutorul unui limbaj de interogare specific. 
4.	Iterator: 
•	Definiție: Acest șablon permite accesul la elementele unei colecții într-un mod secvențial, fără a expune structura internă a colecției. 
•	Exemplu: Într-o aplicație de procesare a datelor, utilizarea unui iterator poate permite itera prin toate rândurile unei baze de date sau a unui fișier CSV, fără a fi nevoie să se încarce întreaga colecție în memorie. 
5.	Mediator: 
•	Definiție: Acest șablon permite comunicarea între obiecte fără a le face să depindă direct unul de celălalt, prin intermediul unui mediator. 
•	Exemplu: Un sistem de mesagerie care permite utilizatorilor să trimită mesaje între ei poate utiliza acest șablon pentru a gestiona comunicarea între utilizatori și pentru a evita dependențele directe între obiectele utilizatorilor. 
6.	Observer: 
•	Definiție: Acest șablon permite unor obiecte să urmărească schimbările de stare ale altor obiecte și să reacționeze în consecință. 
•	Exemplu: O aplicație de monitorizare a sănătății poate utiliza acest șablon pentru a permite medicilor sau personalului medical să primească notificări atunci când datele de monitorizare ale pacienților lor se schimbă sau depășesc anumite limite. 
7.	Strategy (Strategie): 
•	Definiție: Acest șablon permite definirea unei familii de algoritmi, împachetarea fiecărui algoritm într-un obiect și utilizarea lor în mod înlocuibil. 
•	Exemplu: O aplicație de procesare a imaginilor poate utiliza acest șablon pentru a permite utilizatorilor să aleagă între diferite strategii de compresie a imaginilor, cum ar fi JPEG sau PNG, în funcție de nevoile lor specifice.


Acest proiect implementeaza trei sabloane comportamentale: Strategy, Observer si Command.

Sabloanele sunt implementate astfel:
1. Sablonul Strategy este implementat in fisierul ICalculatorStrategy.cs si in clasa Calculator din fisierul Calculator.cs. Interfata ICalculatorStrategy defineste metoda Calculate(), care calculeaza rezultatul operatiei dorite. Clasa Calculator utilizeaza un obiect de tip ICalculatorStrategy pentru a efectua operatii de calcul pe numerele primite ca parametri. De asemenea, clasa Calculator are si o metoda SetStrategy(), care permite schimbarea strategiei de calcul utilizata.
2. Sablonul Observer este implementat in fisierele CalculatorSubject.cs, ICalculatorObserver.cs si Display.cs. Interfata ICalculatorObserver defineste metoda OnCalculation(), care este apelata de obiectul CalculatorSubject atunci cand un eveniment de calcul are loc. Clasa Display este o clasa care implementeaza interfata ICalculatorObserver si afiseaza rezultatul calculului atunci cand este notificata.
3. Sablonul Command este implementat in fisierul ICommand.cs si in clasa CalculatorCommand din acelasi fisier. Interfata ICommand defineste metodele Execute() si Undo(). Clasa CalculatorCommand implementeaza interfata ICommand si reprezinta o comanda care poate fi executata asupra unui CalculatorSubject. Cand comanda este executata, se efectueaza operatia de calcul corespunzatoare si se notifica observatorii atasati.

In fisierul Program.cs se afla functia Main(), care construieste si foloseste obiectele de mai sus. In functie de alegerea utilizatorului, se creaza si se executa o comanda de adunare sau de scadere, folosind strategia corespunzatoare. De fiecare data cand se executa o comanda, se notifica observatorii atasati CalculatorSubject-ului, care afiseaza rezultatul pe ecran.

In concluzie, acest proiect este o implementare buna a sabloanelor comportamentale Strategy, Observer si Command. Sablonul Strategy este folosit pentru a permite schimbarea strategiei de calcul utilizate de un obiect Calculator, fara a schimba codul care foloseste obiectul. Sablonul Observer este folosit pentru a permite afisarea rezultatului unui calcul de catre obiecte care nu sunt responsabile pentru efectuarea acestui calcul. Sablonul Command este folosit pentru a permite executarea unei comenzi asupra unui CalculatorSubject, fara a fi necesar sa se cunoasca detalii despre modul in care se efectueaza acea comanda.
