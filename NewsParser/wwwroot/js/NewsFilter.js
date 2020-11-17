jQuery(function ($){
    $('#filter').click(function (){
        
        if($('#from').val() == '' || $('#to').val() == '') 
            alert("Не все поля заполнены")
            
        else {
            const request = {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                    'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val()
                },
                body: JSON.stringify({From: $('#from').val(), To: $('#to').val()})
            };
            
            fetch("/News/Posts", request)
                .then(response => {
                    response.json().then((data) => {
                        console.log(data);
                        if(data.length === 0)
                        {
                            $('#content').empty();
                            $('#content').append('<h3> По результату ничего не найдено</h3>')
                        }
                        else {
                            $('#content').empty();
                            for (var i = 0; i < data.length; i++) {
                                let row = $('<div class="row mt-2"></div>')
                                let col = $('<div class="col-sm"></div>')
                                let card = $('<div class="card"></div>')
                                let card_body = $('<div class="card-body"></div>')
                                card_body.append('<h5 class="card-title">' + data[i].theme + '</h5>')
                                card_body.append('<p class="card-text">' + data[i].text + '</p>')
                                card.append(card_body)
                                card.append('<div class="card-footer">' + data[i].newsDate.replace("T", " ") + '</div>')
                                col.append(card);
                                row.append(col);
                                $('#content').append(row);
                            }
                        }
                    })
                })
                .catch(function (error) {

                });
        }
    })

})


