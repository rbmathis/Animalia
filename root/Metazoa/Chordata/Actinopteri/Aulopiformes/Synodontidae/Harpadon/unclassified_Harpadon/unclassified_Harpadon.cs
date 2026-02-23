using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae.Harpadon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae.Harpadon.unclassified_Harpadon;

/// <summary>
/// Abstract class for unclassified Harpadon (no rank).
/// NCBI TaxId: 2640092
/// </summary>
public abstract class unclassified_Harpadon : Harpadon, Iunclassified_Harpadon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Harpadon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640092;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Harpadon";
}
