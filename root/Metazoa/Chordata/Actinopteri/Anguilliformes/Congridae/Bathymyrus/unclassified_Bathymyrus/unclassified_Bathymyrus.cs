using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Bathymyrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Bathymyrus.unclassified_Bathymyrus;

/// <summary>
/// Abstract class for unclassified Bathymyrus (no rank).
/// NCBI TaxId: 2976085
/// </summary>
public abstract class unclassified_Bathymyrus : Bathymyrus, Iunclassified_Bathymyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathymyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2976085;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathymyrus";
}
