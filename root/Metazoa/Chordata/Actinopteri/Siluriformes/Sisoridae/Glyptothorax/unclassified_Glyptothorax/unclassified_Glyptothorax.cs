using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Glyptothorax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Glyptothorax.unclassified_Glyptothorax;

/// <summary>
/// Abstract class for unclassified Glyptothorax (no rank).
/// NCBI TaxId: 2626573
/// </summary>
public abstract class unclassified_Glyptothorax : Glyptothorax, Iunclassified_Glyptothorax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Glyptothorax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626573;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Glyptothorax";
}
