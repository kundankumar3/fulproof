<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html>
<head>
<title>StyleCop Violation Report</title>
</head>
<style>
    table, td, th  {
      border: 1px solid #dddddd;
      border-collapse: collapse;
      padding: 8px;
    }

    tr:nth-child(even)  {
      background-color: #dddddd;
    }
</style>
<body>
<!-- This can be changed according to project-->
	<h2>Project Name: FulProof Report</h2>
 <table width= '100%' >
	<tr bgcolor= "#336699">
      <th style="color: white;">StyleCop Violations Details:</th>
    </tr>
 </table>
 <table>
    <tr bgcolor="Teal">
      <th style="color: white;">Source</th>
      <th style="color: white;">LineNumber</th>
	  <th style="color: white;">Section</th>
	  <th style="color: white;">Violation</th>
    </tr>
    <xsl:for-each select="StyleCopViolations/Violation">
    <tr>
      <td><xsl:value-of select="@Source"/></td>
      <td><xsl:value-of select="@LineNumber"/></td>
	  <td><xsl:value-of select="@Section"/></td>
	  <td><xsl:value-of select="."/></td>
    </tr>
    </xsl:for-each>
  </table>
</body>
</html>
</xsl:template>
</xsl:stylesheet>