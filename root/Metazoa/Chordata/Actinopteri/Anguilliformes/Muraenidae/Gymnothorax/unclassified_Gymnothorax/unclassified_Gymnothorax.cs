using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Gymnothorax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Gymnothorax.unclassified_Gymnothorax;

/// <summary>
/// Abstract class for unclassified Gymnothorax (no rank).
/// NCBI TaxId: 2628665
/// </summary>
public abstract class unclassified_Gymnothorax : Gymnothorax, Iunclassified_Gymnothorax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gymnothorax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628665;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gymnothorax";
}
