eventCount = 0

eventos = {
    65: {
        "name": "Teste",
        "date": "MyAss",
        "participants": [],
        "participantsCount": 0,
        "speakers": []
        },
        66: {
            "name": "Teste",
            "date": "MyAss",
            "participants": [],
            "participantsCount": 0,
            "speakers": []
            }
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
            eventos[eventCount] = {
                "name": name,
                "date": dateFormatted,
                "participants": [],
                "speakers": []

            }
            alert("Evento Cadastrado com Sucesso")
            console.log(eventos)
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
    eventListString = "" 
    for (let eventCode in eventos) {
        eventListString = eventListString + String(eventCode) + ": "+eventos[eventCode].name+"\n"
    };
    eventPick = prompt(eventListString+"\n"+"Escolha o código do evento em que você deseja\
 adicionar o participante:")
    alert(`O evento escolhido foi: ${eventPick}`)
    return eventPick 
    }

// https://stackoverflow.com/questions/4060004/calculate-age-given-the-birth-date-in-the-format-yyyymmdd
function getAge(birthDate) {
    var today = new Date();
    // var birthDate = new Date(dateString);
    var age = today.getFullYear() - birthDate.getFullYear();
    var m = today.getMonth() - birthDate.getMonth();
    if (m < 0 || (m === 0 && today.getDate() < birthDate.getDate())) {
        age--;
    }
    return age;
    }

function addParticipant()
{
    selectEvent()
    let name = prompt("Qual é o nome do participante?");
    if (name == null)
    {
        return false
    }

    let birthDate = prompt("Qual é a data de nascimento do participante?");
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
            eventos[eventPick].participants.push([{"name": name, "birthDate": birthDate}])
            alert("Participante Cadastrado com Sucesso")
            console.log(eventos[eventPick].participants)
        }
        else
        {
            alert("Data inválida! O participante deve ter 18 anos ou mais!")
        }
    }
    else
    {
        alert("Data de nascimento inválida! Por favor tente novamente. O formato aceito é dd/mm/aaaa")
    }

}
