using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Coryphaenoides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Coryphaenoides.unclassified_Coryphaenoides;

/// <summary>
/// Abstract class for unclassified Coryphaenoides (no rank).
/// NCBI TaxId: 2643722
/// </summary>
public abstract class unclassified_Coryphaenoides : Coryphaenoides, Iunclassified_Coryphaenoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Coryphaenoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643722;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Coryphaenoides";
}
