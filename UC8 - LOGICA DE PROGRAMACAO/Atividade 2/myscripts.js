eventCount = 0

eventos = {
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
                "participantsCount": 0,
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