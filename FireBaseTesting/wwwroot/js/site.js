//let frms = document.getElementById("form");
//let company = document.getElementById("company");
//let Supplier = document.getElementById("Supplier");
//let PaymentMode = document.getElementById("PaymentMode");
//let Currency = document.getElementById("Currency");
let Remarks = document.getElementById("txtRemarks");
let adjustamount = document.getElementById("adjustamount");
let Quantity = document.getElementById("Quantity");
let netpayable = document.getElementById("netpayable");
let adjustnote = document.getElementById("adjustnote");

console.log(company); 

frms.addEventListener("submit", (e) => {
   alert('You clicked the button');
   e.preventDefault();
   formValidation();
});

let formValidation = () => {
   if (billReference.value === "") {
      console.log("failure");
      msg.innerHTML = "Task cannot be blank";
   } else {
      console.log("success");
      msg.innerHTML = "";
      add.setAttribute("data-bs-dismiss", "modal");
      acceptData();
      add.click();

      (() => {
         add.setAttribute("data-bs-dismiss", "");
      })();
   }
};

let acceptData = () => {
   data.push({
      txtRemarks: txtRemarks.value,
      adjustamount: adjustamount.value,
      Quantity: Quantity.value,
      netpayable: netpayable.value,
      adjustnote: adjustnote.value,
   });

   localStorage.setItem("data", JSON.stringify(data));
   console.log(data);
   createTasks();
};