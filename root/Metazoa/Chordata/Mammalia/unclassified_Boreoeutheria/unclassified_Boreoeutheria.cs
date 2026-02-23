using AnimalKingdom.root.Metazoa.Chordata.Mammalia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.unclassified_Boreoeutheria;

/// <summary>
/// Abstract class for unclassified Boreoeutheria (no rank).
/// NCBI TaxId: 2778474
/// </summary>
public abstract class unclassified_Boreoeutheria : Mammalia, Iunclassified_Boreoeutheria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Boreoeutheria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2778474;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Boreoeutheria";
}
