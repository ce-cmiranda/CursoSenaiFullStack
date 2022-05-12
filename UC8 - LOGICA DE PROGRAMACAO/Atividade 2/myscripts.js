// This will be used to assign a code to an event
eventCount = 0

// Storage of events
events = {
    // Uncomment this event to test 100 participants case 
    // 100: {
    //     "name": "Test",
    //     "date": "This is just a test, there was no validation",
    //     "participants": [[{"name": "Test1", "birthDate": "10/11/1991"},
    // {"name": "Test2", "birthDate": "10/11/1991"},
    // {"name": "Test3", "birthDate": "10/11/1991"},
    // {"name": "Test4", "birthDate": "10/11/1991"},
    // {"name": "Test5", "birthDate": "10/11/1991"},
    // {"name": "Test6", "birthDate": "10/11/1991"},
    // {"name": "Test7", "birthDate": "10/11/1991"},
    // {"name": "Test8", "birthDate": "10/11/1991"},
    // {"name": "Test9", "birthDate": "10/11/1991"},
    // {"name": "Test10", "birthDate": "10/11/1991"},
    // {"name": "Test11", "birthDate": "10/11/1991"},
    // {"name": "Test12", "birthDate": "10/11/1991"},
    // {"name": "Test13", "birthDate": "10/11/1991"},
    // {"name": "Test14", "birthDate": "10/11/1991"},
    // {"name": "Test15", "birthDate": "10/11/1991"},
    // {"name": "Test16", "birthDate": "10/11/1991"},
    // {"name": "Test17", "birthDate": "10/11/1991"},
    // {"name": "Test18", "birthDate": "10/11/1991"},
    // {"name": "Test19", "birthDate": "10/11/1991"},
    // {"name": "Test20", "birthDate": "10/11/1991"},
    // {"name": "Test21", "birthDate": "10/11/1991"},
    // {"name": "Test22", "birthDate": "10/11/1991"},
    // {"name": "Test23", "birthDate": "10/11/1991"},
    // {"name": "Test24", "birthDate": "10/11/1991"},
    // {"name": "Test25", "birthDate": "10/11/1991"},
    // {"name": "Test26", "birthDate": "10/11/1991"},
    // {"name": "Test27", "birthDate": "10/11/1991"},
    // {"name": "Test28", "birthDate": "10/11/1991"},
    // {"name": "Test29", "birthDate": "10/11/1991"},
    // {"name": "Test30", "birthDate": "10/11/1991"},
    // {"name": "Test31", "birthDate": "10/11/1991"},
    // {"name": "Test32", "birthDate": "10/11/1991"},
    // {"name": "Test33", "birthDate": "10/11/1991"},
    // {"name": "Test34", "birthDate": "10/11/1991"},
    // {"name": "Test35", "birthDate": "10/11/1991"},
    // {"name": "Test36", "birthDate": "10/11/1991"},
    // {"name": "Test37", "birthDate": "10/11/1991"},
    // {"name": "Test38", "birthDate": "10/11/1991"},
    // {"name": "Test39", "birthDate": "10/11/1991"},
    // {"name": "Test40", "birthDate": "10/11/1991"},
    // {"name": "Test41", "birthDate": "10/11/1991"},
    // {"name": "Test42", "birthDate": "10/11/1991"},
    // {"name": "Test43", "birthDate": "10/11/1991"},
    // {"name": "Test44", "birthDate": "10/11/1991"},
    // {"name": "Test45", "birthDate": "10/11/1991"},
    // {"name": "Test46", "birthDate": "10/11/1991"},
    // {"name": "Test47", "birthDate": "10/11/1991"},
    // {"name": "Test48", "birthDate": "10/11/1991"},
    // {"name": "Test49", "birthDate": "10/11/1991"},
    // {"name": "Test50", "birthDate": "10/11/1991"},
    // {"name": "Test51", "birthDate": "10/11/1991"},
    // {"name": "Test52", "birthDate": "10/11/1991"},
    // {"name": "Test53", "birthDate": "10/11/1991"},
    // {"name": "Test54", "birthDate": "10/11/1991"},
    // {"name": "Test55", "birthDate": "10/11/1991"},
    // {"name": "Test56", "birthDate": "10/11/1991"},
    // {"name": "Test57", "birthDate": "10/11/1991"},
    // {"name": "Test58", "birthDate": "10/11/1991"},
    // {"name": "Test59", "birthDate": "10/11/1991"},
    // {"name": "Test60", "birthDate": "10/11/1991"},
    // {"name": "Test61", "birthDate": "10/11/1991"},
    // {"name": "Test62", "birthDate": "10/11/1991"},
    // {"name": "Test63", "birthDate": "10/11/1991"},
    // {"name": "Test64", "birthDate": "10/11/1991"},
    // {"name": "Test65", "birthDate": "10/11/1991"},
    // {"name": "Test66", "birthDate": "10/11/1991"},
    // {"name": "Test67", "birthDate": "10/11/1991"},
    // {"name": "Test68", "birthDate": "10/11/1991"},
    // {"name": "Test69", "birthDate": "10/11/1991"},
    // {"name": "Test70", "birthDate": "10/11/1991"},
    // {"name": "Test71", "birthDate": "10/11/1991"},
    // {"name": "Test72", "birthDate": "10/11/1991"},
    // {"name": "Test73", "birthDate": "10/11/1991"},
    // {"name": "Test74", "birthDate": "10/11/1991"},
    // {"name": "Test75", "birthDate": "10/11/1991"},
    // {"name": "Test76", "birthDate": "10/11/1991"},
    // {"name": "Test77", "birthDate": "10/11/1991"},
    // {"name": "Test78", "birthDate": "10/11/1991"},
    // {"name": "Test79", "birthDate": "10/11/1991"},
    // {"name": "Test80", "birthDate": "10/11/1991"},
    // {"name": "Test81", "birthDate": "10/11/1991"},
    // {"name": "Test82", "birthDate": "10/11/1991"},
    // {"name": "Test83", "birthDate": "10/11/1991"},
    // {"name": "Test84", "birthDate": "10/11/1991"},
    // {"name": "Test85", "birthDate": "10/11/1991"},
    // {"name": "Test86", "birthDate": "10/11/1991"},
    // {"name": "Test87", "birthDate": "10/11/1991"},
    // {"name": "Test88", "birthDate": "10/11/1991"},
    // {"name": "Test89", "birthDate": "10/11/1991"},
    // {"name": "Test90", "birthDate": "10/11/1991"},
    // {"name": "Test91", "birthDate": "10/11/1991"},
    // {"name": "Test92", "birthDate": "10/11/1991"},
    // {"name": "Test93", "birthDate": "10/11/1991"},
    // {"name": "Test94", "birthDate": "10/11/1991"},
    // {"name": "Test95", "birthDate": "10/11/1991"},
    // {"name": "Test96", "birthDate": "10/11/1991"},
    // {"name": "Test97", "birthDate": "10/11/1991"},
    // {"name": "Test98", "birthDate": "10/11/1991"},
    // {"name": "Test99", "birthDate": "10/11/1991"},
    // {"name": "Test100", "birthDate": "10/11/1991"}],
    //     "speakers": []
    //     },
}

function isValidDate(date) {
        
        const isValid = date !== "Invalid Date"
        const isDate = !isNaN(date)
        
        return (isValid && isDate)
    }

function formatDate(date){
    dd = date.substring(0,2)
    mm = date.substring(3,5)
    yyyy = date.substring(6,10)
    dateFormat = mm+"/"+dd+"/"+yyyy
    dateFormatted = new Date(dateFormat)
    return dateFormatted
}

function newEvent(){
    let date = prompt("Qual é a data do evento?");
    // Exists if user hits cancel
    if (date == null)
    {
        return false
    }
    
    const dateFormatted = formatDate(date)
    
    if (isValidDate(dateFormatted))
    {   
        today = new Date()
        today = new Date(today.getFullYear(),today.getMonth(),today.getDate(), 0, 0, 0, 0)
        if(dateFormatted>=today)
        {
            let name = prompt("Qual é o nome do evento?");
            eventCount++
            events[eventCount] = {
                "name": name,
                "date": dateFormatted,
                "participants": [],
                "speakers": []
            }
            alert("Evento Cadastrado com Sucesso")
            console.log(events)
        }
        else
        {
            alert("Data inválida! A data do evento deve ser hoje, ou posterior a hoje!")
        }
    }
    else
    {
        alert("Data inválida! Por favor tente novamente. O formato aceito é dd/mm/aaaa")
    }

}

function selectEvent()
    {
    // This variable will store the list of events to be selected
    if (Object.keys(events).length == 0)
    {
        alert("Não há eventos cadastrados!")
        return false
    }
    eventListString = "" 
    for (let eventCode in events) {
        // Add a new event to the selecion list
        eventListString = eventListString + String(eventCode) + ": "+events[eventCode].name+"\n"
    };
    eventPick = prompt(eventListString+"\n"+"Escolha o código do evento em que você deseja\
 adicionar:")
    if (!events[eventPick]){
        alert("Código de evento não encontrado! Por favor tente novamente.")
        return false
    }
    alert(`O evento escolhido foi: ${eventPick}`)
    return eventPick 
    }

// https://stackoverflow.com/questions/4060004/calculate-age-given-the-birth-date-in-the-format-yyyymmdd
function getAge(birthDate) {
    var today = new Date();
    // var birthDate = new Date(dateString);
    var age = today.getFullYear() - birthDate.getFullYear();
    // Validates if the current date is greater than the birthday, to see if the person has aged in the
    // current year
    var m = today.getMonth() - birthDate.getMonth();
    if (m < 0 || (m === 0 && today.getDate() < birthDate.getDate())) {
        age--;
    }
    return age;
    }

function addParticipant(newParticipant = true)
{

    // The while loop will continue untill the user chooses to continue to add new Participants,
    // or untill some invalid data is inputed
    // or the participant limit is reached
    while (newParticipant)
    {
        eventPick = selectEvent()
        if (!eventPick)
        {
            return false
        }

        if (events[eventPick].participants.length >= 100)
        {
            alert("O limite de participantes no evento é 100. Não há mais vagas.")
            newParticipant = false
            return false

        }
        let name = prompt("Qual é o nome do participante?");
        // Exits if the user hits cancel
        if (name == null)
        {
            return false
        }

        let birthDate = prompt("Qual é a data de nascimento do participante?");
        // Exits if the user hits cancel
        if (birthDate == null)
        {
            return false
        }
        const dateFormatted = formatDate(birthDate)

        if (isValidDate(dateFormatted))
        {   
            today = new Date()
            today = new Date(today.getFullYear(),today.getMonth(),today.getDate(), 0, 0, 0, 0)
            if(getAge(dateFormatted)>=18)
            {
                // Adds the participant to the event's list
                events[eventPick].participants.push({"name": name, "birthDate": birthDate})
                alert("Participante Cadastrado com Sucesso")
                console.log(events[eventPick].participants)

                addNew = prompt("Deseja adicionar um novo participante? (Digite sim para continuar)")
                newParticipant = false
                if (addNew.toLowerCase() == "sim")
                {
                    addParticipant()
                }
                else{
                    alert("Não foi digitado sim, então encerraremos por aqui o cadastro")
                }

            }
            else
            {
                alert("Data inválida! O participante deve ter 18 anos ou mais! Tente novamente!")
                return false
            }
        }
        else
        {
            alert("Data de nascimento inválida! Por favor tente novamente. O formato aceito é dd/mm/aaaa")
        }
    }
    

}


function addSpeaker()
{
    eventPick = selectEvent()
    if (!eventPick)
    {
        return false
    }
    let name = prompt("Qual é o nome do palestrante?");
    if (name == null)
    {
        return false
    }

    // Adds the speaker to the event's list
    events[eventPick].speakers.push({"name": name})
    alert("Palestrante Cadastrado com Sucesso")
    console.log(events[eventPick].speakers)
}

function listEvents()
{
    eventPick = selectEvent()
    if (!eventPick)
    {
        return false
    }

    listString = ""

    if (events[eventPick].speakers.length > 0){
        listString = listString + "Lista de palestrantes:\n"
        for (let speakerCode in events[eventPick].speakers) {
            listString = listString + events[eventPick].speakers[speakerCode].name+"\n"
        };
    }
    else{
        listString = listString + "Este evento não possui palestrantes cadastrados\n"
    }

    if (events[eventPick].participants.length > 0){
        listString = listString + "\nLista de participantes:\n"
        for (let participantCode in events[eventPick].participants) {
            listString = listString + events[eventPick].participants[participantCode].name+"\n"
        };
    }
    else{
        listString = listString + "\nEste evento não possui participantes cadastrados\n"
    }

    alert(listString)
}

