using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Diplomystidae.Diplomystes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Diplomystidae.Diplomystes.unclassified_Diplomystes;

/// <summary>
/// Abstract class for unclassified Diplomystes (no rank).
/// NCBI TaxId: 2633454
/// </summary>
public abstract class unclassified_Diplomystes : Diplomystes, Iunclassified_Diplomystes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diplomystes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633454;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diplomystes";
}
