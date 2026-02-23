using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Merlucciidae.Macruronus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Merlucciidae.Macruronus.unclassified_Macruronus;

/// <summary>
/// Abstract class for unclassified Macruronus (no rank).
/// NCBI TaxId: 2625324
/// </summary>
public abstract class unclassified_Macruronus : Macruronus, Iunclassified_Macruronus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Macruronus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625324;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Macruronus";
}
