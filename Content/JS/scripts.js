



  $('#addGroup').click(function() {
    $('#newGroupForm').toggleClass('hidden');
  });
  $('#newGroupForm').submit(function(event) {
    event.preventDefault();
    var newGroup = $('#newGroup').val();
    $('#group').append("<option value='" + newGroup + "'>" + newGroup + "</option>");
    $('#newGroup').val('');
    $('#newGroupForm').toggleClass('hidden');
  });
