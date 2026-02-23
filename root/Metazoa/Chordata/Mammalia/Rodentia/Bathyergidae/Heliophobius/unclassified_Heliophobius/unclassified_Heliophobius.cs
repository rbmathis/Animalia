using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Heliophobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Heliophobius.unclassified_Heliophobius;

/// <summary>
/// Abstract class for unclassified Heliophobius (no rank).
/// NCBI TaxId: 2630831
/// </summary>
public abstract class unclassified_Heliophobius : Heliophobius, Iunclassified_Heliophobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heliophobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630831;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heliophobius";
}
