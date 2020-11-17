jQuery(function ($){
    const request = {
        method: "GET",
    };
            
    fetch("/News/TopTen", request)
                .then(response => {
                    response.json().then((data) => {
                        console.log(data);
                            $('#rate').empty();
                            for (var i = 0; i < data.length; i++) {
                                let row = $('<tr></tr>')
                                row.append('<td>'+data[i].Key+'</td>');
                                row.append('<td>'+data[i].Value+'</td>');
                                $('#rate').append(row);
                            }
                    })
                })
        .catch(function (error) {
        });

})


