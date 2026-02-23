using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Plataplochilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Plataplochilus.unclassified_Plataplochilus;

/// <summary>
/// Abstract class for unclassified Plataplochilus (no rank).
/// NCBI TaxId: 2623539
/// </summary>
public abstract class unclassified_Plataplochilus : Plataplochilus, Iunclassified_Plataplochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plataplochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623539;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plataplochilus";
}
