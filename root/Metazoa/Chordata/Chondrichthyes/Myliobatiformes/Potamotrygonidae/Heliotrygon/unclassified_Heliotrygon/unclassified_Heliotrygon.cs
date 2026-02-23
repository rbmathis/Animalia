using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae.Heliotrygon;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae.Heliotrygon.unclassified_Heliotrygon;

/// <summary>
/// Abstract class for unclassified Heliotrygon (no rank).
/// NCBI TaxId: 2621359
/// </summary>
public abstract class unclassified_Heliotrygon : Heliotrygon, Iunclassified_Heliotrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heliotrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621359;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heliotrygon";
}
