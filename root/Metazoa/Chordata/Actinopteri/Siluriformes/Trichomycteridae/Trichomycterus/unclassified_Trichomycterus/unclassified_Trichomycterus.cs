using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Trichomycterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Trichomycterus.unclassified_Trichomycterus;

/// <summary>
/// Abstract class for unclassified Trichomycterus (no rank).
/// NCBI TaxId: 2602707
/// </summary>
public abstract class unclassified_Trichomycterus : Trichomycterus, Iunclassified_Trichomycterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trichomycterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2602707;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trichomycterus";
}
