

let filterarray = [];

let galleryarray = [

    {
        id:1,
        name : "tanduay select",
        scr : "./others/img/tanduay.png",
        desc: "lorem",
    },
    {
        id:2,
        name : "Gin",
        scr : "./others/img/gin.png",
        desc: "lorem",
    },
    {
        id:3,
        name : "Redhorse",
        scr : "./others/img/redhorse.png",
        desc: "lorem",
    },
    {
        id:4,
        name : "Fundador",
        scr : "./others/img/fundador.png",
        desc: "lorem",
    },
    {
        id:5,
        name : "Emperador",
        scr : "./others/img/emperador.png",
        desc: "lorem",
    },
    {
        id:6,
        name : "Tanduay Dark",
        scr : "./others/img/tanduayDark.png",
        desc: "lorem",
    },

    
   
    
]

    showgallery(galleryarray)

    function showgallery(curarray){

        document.getElementById("card").innerText = "";

        for(var i=0;i<curarray.length;i++){
            document.getElementById("card").innerHTML +=`
                <div class="col-md-4 mt-3">
                    <div class="card p-3 ps-5 pe-5">
                        <h4 class="text-capitalize text-center">${curarray[i].name}</h4>
                        <img src="${curarray[i].scr}" class="img-fluid mt-2">
                        <button class="btn btn-primary w-100 mx-auto" style="background-color: coral; ">Add to cart</button>       
                    </div>
                </div>`
        }
        

    }

    document.getElementById("myinput").addEventListener("keyup", function() {
        let text = document.getElementById("myinput").value;
      
        filterarray = galleryarray.filter(function(a) {
            if (a.name.toLowerCase().includes(text.toLowerCase())) {
              return a.name;
            }
        });
      
        if (this.value == "") {
          showgallery(galleryarray);
        } else {
          if (filterarray == "") {
            document.getElementById("para").style.display = 'block';
            document.getElementById("card").innerHTML = "";
          } else {
            showgallery(filterarray);
            document.getElementById("para").style.display = 'none';
          }
        }
      });

      
document.getElementById("addProductForm").addEventListener("submit", function(event) {
    event.preventDefault();

    let productName = document.getElementById("productName").value;
    let productImage = document.getElementById("productImage").files[0];
    let productDesc = document.getElementById("productDesc").value;

    // Create a new object with the retrieved values
    let newProduct = {
        id: galleryarray.length + 1,
        name: productName,
        scr: "./others/img/" + productImage.name,
        desc: productDesc
    };


    galleryarray.push(newProduct);


    showgallery(galleryarray);

 
    document.getElementById("addProductForm").reset();

});

