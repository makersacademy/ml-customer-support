document.addEventListener('DOMContentLoaded', function () {
    const addRequestForm = document.getElementById('addRequestForm');
    const requestList = document.getElementById('requestList');

    addRequestForm.addEventListener('submit', function (e) {
        e.preventDefault();
        const formData = new FormData(addRequestForm);
        fetch('/SupportRequest/AddRequest', {
            method: 'POST',
            body: formData
        }).then(response => response.text())
          .then(html => {
              const tempDiv = document.createElement('div');
              tempDiv.innerHTML = html;
              const newRequest = tempDiv.querySelector('.request-item');
              if (newRequest) {
                  requestList.prepend(newRequest);
              }
              addRequestForm.reset();
          });
    });

    requestList.addEventListener('submit', function (e) {
        if (e.target.matches('form')) {
            e.preventDefault();
            const formData = new FormData(e.target);
            fetch('/SupportRequest/ResolveRequest', {
                method: 'POST',
                body: formData
            }).then(response => response.text())
              .then(html => {
                  const tempDiv = document.createElement('div');
                  tempDiv.innerHTML = html;
                  const updatedRequests = tempDiv.querySelectorAll('.request-item');
                  requestList.innerHTML = '';
                  updatedRequests.forEach(request => {
                      requestList.appendChild(request);
                  });
              });
        }
    });
});