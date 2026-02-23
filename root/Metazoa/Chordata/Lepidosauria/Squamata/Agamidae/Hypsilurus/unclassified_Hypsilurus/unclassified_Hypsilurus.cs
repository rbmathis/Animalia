using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Hypsilurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Hypsilurus.unclassified_Hypsilurus;

/// <summary>
/// Abstract class for unclassified Hypsilurus (no rank).
/// NCBI TaxId: 2624685
/// </summary>
public abstract class unclassified_Hypsilurus : Hypsilurus, Iunclassified_Hypsilurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypsilurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624685;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypsilurus";
}
