using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Pseudotrapelus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Pseudotrapelus.unclassified_Pseudotrapelus;

/// <summary>
/// Abstract class for unclassified Pseudotrapelus (no rank).
/// NCBI TaxId: 2645566
/// </summary>
public abstract class unclassified_Pseudotrapelus : Pseudotrapelus, Iunclassified_Pseudotrapelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudotrapelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645566;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudotrapelus";
}
