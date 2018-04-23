# How to show a large image in a popup when a small image in a list view column is clicked


<p>By default, XAF opens a detail view in response to a double-click in a list view row.  This behavior can be changed by handling the ListViewProcessCurrentObjectController.CustomProcessSelectedItem event. Since we want to show an image for double-clicks in Image type columns, we should determine the element under the click point using the GridHitInfo object.</p>

<br/>


