using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Lemmus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Lemmus.unclassified_Lemmus;

/// <summary>
/// Abstract class for unclassified Lemmus (no rank).
/// NCBI TaxId: 2639651
/// </summary>
public abstract class unclassified_Lemmus : Lemmus, Iunclassified_Lemmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lemmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639651;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lemmus";
}
