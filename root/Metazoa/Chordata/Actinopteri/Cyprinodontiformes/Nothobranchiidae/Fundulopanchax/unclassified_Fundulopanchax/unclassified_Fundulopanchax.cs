using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Fundulopanchax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Fundulopanchax.unclassified_Fundulopanchax;

/// <summary>
/// Abstract class for unclassified Fundulopanchax (no rank).
/// NCBI TaxId: 2622578
/// </summary>
public abstract class unclassified_Fundulopanchax : Fundulopanchax, Iunclassified_Fundulopanchax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Fundulopanchax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622578;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Fundulopanchax";
}
