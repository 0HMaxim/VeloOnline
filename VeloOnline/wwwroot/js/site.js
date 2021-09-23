    
$('#bike-list')
    .load(`/Home/BikeList`)



$("#searchBtn").on("click", function () {
    let searchData = $("#searchText").val()

    $('#bike-list')
        .load(`/Home/BikeList/?search=${searchData}`)
})