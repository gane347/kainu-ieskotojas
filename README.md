# kainu-ieskotojas
Ši programa randa produktų kainas Excel faile, kuriame nurodytos produktų nuorodos. Kol kas veikia tik su pigu.lt ir varle.lt nuorodomis

1.	Ar programa patikima?
Ši programa nesiunčia jokių duomenų į išorę, tik atidaro internetą, kad pažiūrėti kainas. Viskas veikia tik jūsų kompiuteryje (išskyrus prekių kainų paiešką), todėl galite būti užtikrinti, kad duomenys nėra renkami. Programa nėra pilnai ištestuota, todėl gali nutikti nenumatytų atvejų, todėl rekomenduojama rezultatą saugoti į kitą failą.
Programa yra open-source, tai reiškia, kad jos kodas prieinamas visiems, todėl galima matyti, ką programa tiksliai daro. Ją galima pasiekti
2.	Kaip instaliuoti programą?
Parsisiuntus kainu ieskotojas.zip, jį reikia išskleisti bet kuriame aplanke. Aplanko viduje bus Kainu ieskotojas piktograma (2.1 pav.), kurią galima vilkti bet kur (pvz. ant darbalaukio), su ja galima pasiekti programą.
 
3.	Kaip naudotis programa?

Atsidarius programą matoma vartotojo sąsaja (3.1 pav.). Paprasčiausiam naudojimui galima pasirinkti failą iš kurio norime skaityti su 1 mygtuku, tada programa modifikuos failą, tačiau rekomenduotina pažymėti varnelę 2 ir su 3 mygtuku pasirinkti kur bus išsaugotas failas, nes nenumatytas programos veikimas gali negrįžtamai pažeisti failą.
Šie nustatymai tinka pavyzdiniui failui, tačiau jūsų failas gali atrodyti kitaip, todėl paspaudus 4 varnelę galima pakeisti nustatymus:
•	5 ir 6 langelyje galima įvesti nuo kurios iki kurios eilutės programa ieškos kainų.
•	7 langelyje galima įvesti kuriame stulpelyje yra nuorodos (šiuo metu programa dirba su varle.lt ir pigu.lt nuorodomis)
•	8 langelyje galima įvesti į kurį stulpelį bus įrašytos kainos.
•	Pažymėjus 9 varnelę programa lygins naujai įvestas kainas su senomis, kurios yra įrašytos į stulpelį, kurį reikėtų nurodyti 10 langelyje. Jei kaina padidėjo, langelis spalvinamas raudonai, jei sumažėjo – žaliai.
•	Pažymėjus 11 varnelę galima ranka spręsti CAPTCHA, jei jų yra. Rekomenduojama nežymėti.
•	Pažymėjus 12 varnelę programa ieškos kainų internete. Jei senos ir naujos kainos jau yra irašytos, galima varnelės nežymėti, o tik palyginti jas.

4.	Kaip veikia programa?
Programa skaito kiekvieną eilutę excel faile, kuri nurodyta intervale. Jei randama puslapių, kuriuos galima aplankyti, programa, naudojantis Google Chrome, aplanko juos ir randa puslapio elementus, kuriuose rašoma kaina ir įrašo ją į atitinkamos eilutės atitinkama stulpelį. 
Jei pasirinkta kainas palyginti, programa skaito kiekvieną eilutę excel faile, kuri nurodyta intervale, ir lygina jų kainas ir atitinkamai nuspalvina langelį.
5.	Kodėl atsidaro Google Chrome langai?
Puslapiai bando apsisaugoti nuo įvairių užpuolimų, todėl dažnai neleidžia programoms lankytis puslapiuose. Kartais ir ši programa laikoma grėsme, todėl atidaromas Google Chrome ekrane, kad atrodytų, kad lankosi žmogus. Tik retais atvejais tai turėtų nutikti. Jei tai dažnai kartojasi, reikėtų pabandyti išjugti VPN (jei įjungtas) arba pakeisti Wi-Fi jungtį.

7.	Iškilo problema, kuri neaprašyta
Susisiekite asmeniškai su kūrėju, nurodykite kokius veiksmus darėte, pridėkite praplėsto lango (su programos išvestimi) ekrano nuotrauką.
