using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Congriscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Congriscus.unclassified_Congriscus;

/// <summary>
/// Abstract class for unclassified Congriscus (no rank).
/// NCBI TaxId: 2641520
/// </summary>
public abstract class unclassified_Congriscus : Congriscus, Iunclassified_Congriscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Congriscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641520;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Congriscus";
}
