var tokenKey = "access_token"



function createTableRow(bike) {
    const tr = document.createElement('tr')

    const titleTd = document.createElement('td')
    titleTd.append(bike.title)
    tr.append(titleTd)

    const manufacturerTd = document.createElement('td')
    manufacturerTd.append(bike.manufacturer)
    tr.append(manufacturerTd)


    const imageUrlTd = document.createElement('td')
    const imageUrl = document.createElement('img')
    imageUrl.src = bike.imageUrl
    imageUrl.width = 200;
    imageUrlTd.append(imageUrl)
    tr.append(imageUrlTd)

    const descriptionTd = document.createElement('td')
    descriptionTd.append(bike.description)
    tr.append(descriptionTd)

    const wheelSizeTd = document.createElement('td')
    wheelSizeTd.append(bike.wheelSize)
    tr.append(wheelSizeTd)

    const numberOfSpeedsTd = document.createElement('td')
    numberOfSpeedsTd.append(bike.numberOfSpeeds)
    tr.append(numberOfSpeedsTd)

    const weightTd = document.createElement('td')
    weightTd.append(bike.weight)
    tr.append(weightTd)

    const priceTd = document.createElement('td')
    priceTd.append(bike.price)
    tr.append(priceTd)

    const editTd = document.createElement('td')
    editTd.innerHTML =`
       <td>
           <input type="button" value="Edit" class="btn btn-warning edit" />

     <dialog id="${bike.bikeId} ">
    <div style="width:300px;">
        <input type="hidden" value="${bike.bikeId}" name=bikeId/>

    <div>
          <label class="form-control">Title</label>
          <input type="text" class="form-control" name="title" value="${bike.title}"/>
    </div>

    <div>
          <label class="form-control">Manufacturer</label>
          <input type="text" class="form-control" name="manufacturer" value="${bike.manufacturer}""/>
    </div>

    <div>
          <label class="form-control">Wheel Size</label>
          <input type="text" class="form-control" name="wheelSize" value="${bike.wheelSize}""/>
    </div>

    <div>
          <label class="form-control">Number of speeds</label>
          <input type="text" class="form-control" name="numberOfSpeeds" value="${bike.numberOfSpeeds}""/>
    </div>

    <div>
         <label class="form-control">Weight</label>
         <input type="text" class="form-control" name="weight" value="${bike.weight}""/>
    </div>

    <div>
         <label class="form-control">Price</label>
         <input type="text" class="form-control" name="price" value="${bike.price}""/>
    </div>

    <div>
         <label class="form-control">ImageUrl</label>
         <input type="text" class="form-control" name="imageUrl" value="${bike.imageUrl}""/>
    </div>


    <div>
         <label class="form-control">Description</label>
         <input type="text" class="form-control" name="description" value="${bike.description}""/>
    </div>



    <div class="container d-flex justify-content-between mt-2">
         <button id="bike${bike.bikeId}" class="btn btn-danger col-5" type="reset">Cancel</button>
         <button class="btn btn-primary col-5">Save</button>
    </div>
    </div>

        </dialog>

       </td>`
    tr.append(editTd)

    const deleteTd = document.createElement('td')
    deleteTd.innerHTML = `
    <td>
           <input type="hidden" value="${bike.bikeId}"/>
           <input type="button" value="Delete" class="btn btn-danger delete" />
    </td>`
    tr.append(deleteTd)

    return tr
}

function updateEvents() {
    var listDelete = document.getElementsByClassName("delete")

    for (let i = 0; i < listDelete.length; i++) {

        listDelete[i].addEventListener('click', async function () {

            var bikeId = this.parentElement.childNodes[1].value

            const token = sessionStorage.getItem(tokenKey)
            const responseDelete = await fetch(`/api/Bike/${bikeId}`, {
                method: 'DELETE',
                headers: {
                    'Authorization': 'bearer ' + token,
                }
            });
            if (responseDelete.ok === true) {
                this.parentElement.parentElement.innerHTML = ""
            }
        })
    }

    var listEdit = document.getElementsByClassName("edit")

    for (let i = 0; i < listEdit.length; i++) {

        listEdit[i].addEventListener('click', async function () {

            var childNodesTd = this.parentElement.childNodes
            var modal = document.getElementById(childNodesTd[3].id)


            childNodesTd[3].showModal();



            modal.childNodes[1].childNodes[19].childNodes[1].addEventListener('click', function () {
                modal.close();
            });



            modal.childNodes[1].childNodes[19].childNodes[3].addEventListener('click', async function (e) {

                e.preventDefault();


                let bikeId = modal.childNodes[1].childNodes[1].value
                let title = modal.childNodes[1].childNodes[3].childNodes[3].value
                let manufacturer = modal.childNodes[1].childNodes[5].childNodes[3].value
                let wheelSize = modal.childNodes[1].childNodes[7].childNodes[3].value
                let numberOfSpeeds = modal.childNodes[1].childNodes[9].childNodes[3].value
                let weight = modal.childNodes[1].childNodes[11].childNodes[3].value
                let price = modal.childNodes[1].childNodes[13].childNodes[3].value
                let imageUrl = modal.childNodes[1].childNodes[15].childNodes[3].value
                let description = modal.childNodes[1].childNodes[17].childNodes[3].value




                const token = sessionStorage.getItem(tokenKey)
                const response = await fetch('/api/Bike/', {
                    method: "PUT",
                    headers: {
                        'Authorization': 'bearer ' + token,
                        'Content-Type': 'application/json',
                        'Accept': 'application/json'
                    },
                    body: JSON.stringify({
                        "bikeId": +bikeId,
                        "title": title,
                        "manufacturer": manufacturer,
                        "imageUrl": imageUrl,
                        "description": description,
                        "wheelSize": +wheelSize,
                        "numberOfSpeeds": +numberOfSpeeds,
                        "weight": +weight,
                        "price": +price,
                    })
                })

                if (response.ok === true) {
                    const bike = await response.json()

                    this.parentElement.parentElement.parentElement.parentElement.parentElement.innerHTML = `

                    <td>${bike.title}</td>
                    <td>${bike.manufacturer}</td>
                    <td>
                        <img src="${bike.imageUrl}" style="width:200px;"/>
                    </td>
                    <td>${bike.description}</td>
                    <td>${bike.wheelSize}</td>
                    <td>${bike.numberOfSpeeds}</td>
                    <td>${bike.weight}</td>
                    <td>${bike.price}</td>
                    <td>
                    <input type="button" value="Edit" class="btn btn-warning edit" />

                        <dialog id="${bike.bikeId}">
                        <div style="width:300px;">
                        <input type="hidden" value="${bike.bikeId}" name=bikeId/>

                        <div>
                               <label class="form-control">Title</label>
                               <input type="text" class="form-control" name="title" value="${bike.title}"/>
                        </div>

                        <div>
                              <label class="form-control">Manufacturer</label>
                              <input type="text" class="form-control" name="manufacturer" value="${bike.manufacturer}""/>
                        </div>

                        <div>
                              <label class="form-control">Wheel Size</label>
                              <input type="text" class="form-control" name="wheelSize" value="${bike.wheelSize}""/>
                        </div>

                        <div>
                              <label class="form-control">Number of speeds</label>
                              <input type="text" class="form-control" name="numberOfSpeeds" value="${bike.numberOfSpeeds}""/>
                        </div>

                        <div>
                             <label class="form-control">Weight</label>
                             <input type="text" class="form-control" name="weight" value="${bike.weight}""/>
                        </div>

                        <div>
                             <label class="form-control">Price</label>
                             <input type="text" class="form-control" name="price" value="${bike.price}""/>
                        </div>

                        <div>
                             <label class="form-control">ImageUrl</label>
                             <input type="text" class="form-control" name="imageUrl" value="${bike.imageUrl}""/>
                        </div>

                        <div>
                             <label class="form-control">Description</label>
                             <input type="text" class="form-control" name="description" value="${bike.description}""/>
                        </div>

                        <div class="container d-flex justify-content-between mt-2">
                             <button id="bike${bike.bikeId}" class="btn btn-danger col-5" type="reset">Cancel</button>
                             <button class="btn btn-primary col-5">Save</button>
                        </div>
                        </div>

                    </dialog>

                    </td>
                        <td>
                               <input type="hidden" value="${bike.bikeId}"/>
                               <input type="button" value="Delete" class="btn btn-danger delete" />
                        </td>`

                    modal.close();
                    updateEvents();
                }
            });



        })
    }
}

async function getBikes() {
    const token = sessionStorage.getItem(tokenKey)
    const response = await fetch('/api/Bike', {
        method: 'GET',
        headers: {
            'Authorization': 'bearer ' + token
        }
    })

    if (response.ok === true) {
        const bikes = await response.json()
        let rows = document.querySelector('tbody')
        bikes.forEach(bike => rows.append(createTableRow(bike)))
        updateEvents();
    }
}


async function createBike(title, manufacturer, imageUrl,
    description, wheelSize, numberOfSpeeds,
    weight, price) {
    const token = sessionStorage.getItem(tokenKey)
    const response = await fetch('/api/Bike', {
        method: 'POST',
        headers: {
            'Authorization': 'bearer ' + token,
            'Content-Type': 'application/json',
            'Accept': 'application/json'
        },
        body: JSON.stringify({
            "title": title,
            "manufacturer": manufacturer,
            "imageUrl": imageUrl,
            "description": description,
            "wheelSize": +wheelSize,
            "numberOfSpeeds": +numberOfSpeeds,
            "weight": +weight,
            "price": +price,
        })
    })

    if (response.ok === true) {
        const bike = await response.json()
        document.querySelector('tbody').append(createTableRow(bike))



        const form = document.forms['bikeForm']
        form.elements['title'].value = null
        form.elements['manufacturer'].value = null
        form.elements['imageUrl'].value = null
        form.elements['description'].value = null
        form.elements['wheelSize'].value = null
        form.elements['numberOfSpeeds'].value = null
        form.elements['weight'].value = null
        form.elements['price'].value = null


    } else {
        document.getElementById('errors').innerHTML = ''

        const errorData = await response.json()
        console.log(errorData)
        console.log(errorData.errors)

        if (errorData) {
            if (errorData.errors) {
                for (let error in errorData.errors) {
                    showError(errorData.errors[error])
                }
            }

            document.getElementById('errors').style.display = 'block'
        }

    }
}

function showError(errors) {
    errors.forEach(error => {
        const p = document.createElement('p')
        p.append(error)
        document.getElementById('errors').append(p)
    })
}

document.forms['bikeForm'].addEventListener('submit', function (e) {
    e.preventDefault()
    const form = document.forms['bikeForm']
    const title = form.elements['title'].value
    const manufacturer = form.elements['manufacturer'].value
    const imageUrl = form.elements['imageUrl'].value
    const description = form.elements['description'].value
    const wheelSize = form.elements['wheelSize'].value
    const numberOfSpeeds = form.elements['numberOfSpeeds'].value
    const weight = form.elements['weight'].value
    const price = form.elements['price'].value

    createBike(title, manufacturer, imageUrl,
        description, wheelSize, numberOfSpeeds,
        weight, price)
})


getBikes()


async function getTokenAsync() {
    const credentials = {
        login: document.getElementById('login').value,
        password: document.getElementById('password').value
    }

    const response = await fetch('api/account/token', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(
            {
                "login": credentials.login,
                "password": credentials.password
            }
        )
    })

    const data = await response.json()
    if (response.ok === true) {
        sessionStorage.setItem(tokenKey, data.access_token)
        getBikes()
    } else {
        console.log(response.status, response.errorText)
    }
}


document.getElementById('submitForm').addEventListener('click', function () {
    getTokenAsync()
})


