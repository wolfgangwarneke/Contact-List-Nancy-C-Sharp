



$('#addGroup').click(function() {
  $('#newGroupForm, #addGroup').toggleClass('hidden');
});
$('#newGroupForm').submit(function(event) {
  event.preventDefault();
  var newGroup = $('#newGroup').val();
  $('#group').append("<option value='" + newGroup + "'>" + newGroup + "</option>");
  $('#newGroup').val('');
  $('#newGroupForm, #addGroup').toggleClass('hidden');
  $('#group option:contains(' + newGroup + ')').prop('selected', true);
});


$('#sortByGroup').change(function() {
  document.forms["groupsort"].submit();
});
