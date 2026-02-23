using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae.Potamotrygon;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae.Potamotrygon.unclassified_Potamotrygon;

/// <summary>
/// Abstract class for unclassified Potamotrygon (no rank).
/// NCBI TaxId: 2648408
/// </summary>
public abstract class unclassified_Potamotrygon : Potamotrygon, Iunclassified_Potamotrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Potamotrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648408;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Potamotrygon";
}
