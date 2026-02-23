using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae.unclassified_Potamotrygonidae;

/// <summary>
/// Abstract class for unclassified Potamotrygonidae (no rank).
/// NCBI TaxId: 2841182
/// </summary>
public abstract class unclassified_Potamotrygonidae : Potamotrygonidae, Iunclassified_Potamotrygonidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Potamotrygonidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2841182;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Potamotrygonidae";
}
