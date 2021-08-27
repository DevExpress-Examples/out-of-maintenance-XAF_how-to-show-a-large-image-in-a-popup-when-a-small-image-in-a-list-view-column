<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128593431/10.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2828)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [ShowImageController.cs](./CS/Solution15.Module.Win/ShowImageController.cs) (VB: [ShowImageController.vb](./VB/Solution15.Module.Win/ShowImageController.vb))
<!-- default file list end -->
# How to show a large image in a popup when a small image in a list view column is clicked


<p>By default, XAF opens a detail view in response to a double-click in a list view row.  This behavior can be changed by handling the ListViewProcessCurrentObjectController.CustomProcessSelectedItem event. Since we want to show an image for double-clicks in Image type columns, we should determine the element under the click point using the GridHitInfo object.</p>

<br/>


