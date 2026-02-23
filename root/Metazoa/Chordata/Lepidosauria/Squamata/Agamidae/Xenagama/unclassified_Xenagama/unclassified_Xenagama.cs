using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Xenagama;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Xenagama.unclassified_Xenagama;

/// <summary>
/// Abstract class for unclassified Xenagama (no rank).
/// NCBI TaxId: 2625661
/// </summary>
public abstract class unclassified_Xenagama : Xenagama, Iunclassified_Xenagama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xenagama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625661;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xenagama";
}
