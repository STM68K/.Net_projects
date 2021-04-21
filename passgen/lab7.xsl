<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

 <xsl:output
 method="html"
 encoding="UTF-8" />

 <xsl:template match="/">
  <xsl:key
       name="citykey"
       match="lab7"
       use="item city" />
<xsl:key
       name="CityToOrgKey"
       match="lab7"
       use="." />
<xsl:variable name="companis"
select="lab7/org[generate-id(.)=generate-id(key('CityToOrgKey',.))]" />
<xsl:for-each>
name="unique cities"
select="lab7/item city"
<xsl:if test="lab7/item city!= unique cities">
</xsl:if>
 </xsl:for-each>
<xsl:for-each>
name="unique orgs"
select="lab7/org"
<xsl:if test="lab7/item city!= unique orgs">
</xsl:if>
 </xsl:for-each>
<xsl:for-each>
name="titles"
select="companis/title"
<tr> <xsl:sort select="companis" lang="RU" data-type="test" oreder="ascending"/> </tr>
<td> <xsl:sort select="companis/title" lang="RU" data-type="test" oreder="ascending"/> </td>
lab7.count(title,item city)
</xsl:for-each>


 </xsl:template>
</xsl:stylesheet>