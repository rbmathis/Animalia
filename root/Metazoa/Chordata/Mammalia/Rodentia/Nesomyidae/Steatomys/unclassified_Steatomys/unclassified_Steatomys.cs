using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Steatomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Steatomys.unclassified_Steatomys;

/// <summary>
/// Abstract class for unclassified Steatomys (no rank).
/// NCBI TaxId: 2628573
/// </summary>
public abstract class unclassified_Steatomys : Steatomys, Iunclassified_Steatomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Steatomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628573;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Steatomys";
}
