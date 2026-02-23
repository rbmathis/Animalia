using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Melanorivulus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Melanorivulus.unclassified_Melanorivulus;

/// <summary>
/// Abstract class for unclassified Melanorivulus (no rank).
/// NCBI TaxId: 2624160
/// </summary>
public abstract class unclassified_Melanorivulus : Melanorivulus, Iunclassified_Melanorivulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Melanorivulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624160;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Melanorivulus";
}
