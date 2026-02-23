using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Natalidae.Natalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Natalidae.Natalus.unclassified_Natalus;

/// <summary>
/// Abstract class for unclassified Natalus (no rank).
/// NCBI TaxId: 2625265
/// </summary>
public abstract class unclassified_Natalus : Natalus, Iunclassified_Natalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Natalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625265;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Natalus";
}
