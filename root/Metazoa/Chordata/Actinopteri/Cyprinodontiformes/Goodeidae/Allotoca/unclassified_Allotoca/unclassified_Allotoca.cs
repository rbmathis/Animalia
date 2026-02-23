using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Allotoca;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Allotoca.unclassified_Allotoca;

/// <summary>
/// Abstract class for unclassified Allotoca (no rank).
/// NCBI TaxId: 2631433
/// </summary>
public abstract class unclassified_Allotoca : Allotoca, Iunclassified_Allotoca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Allotoca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631433;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Allotoca";
}
