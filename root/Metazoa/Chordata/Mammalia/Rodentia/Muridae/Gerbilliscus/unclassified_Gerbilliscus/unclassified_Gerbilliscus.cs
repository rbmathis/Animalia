using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Gerbilliscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Gerbilliscus.unclassified_Gerbilliscus;

/// <summary>
/// Abstract class for unclassified Gerbilliscus (no rank).
/// NCBI TaxId: 2629467
/// </summary>
public abstract class unclassified_Gerbilliscus : Gerbilliscus, Iunclassified_Gerbilliscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gerbilliscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629467;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gerbilliscus";
}
