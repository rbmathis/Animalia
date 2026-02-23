using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Ellochelon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Ellochelon.unclassified_Ellochelon;

/// <summary>
/// Abstract class for unclassified Ellochelon (no rank).
/// NCBI TaxId: 2620837
/// </summary>
public abstract class unclassified_Ellochelon : Ellochelon, Iunclassified_Ellochelon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ellochelon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620837;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ellochelon";
}
