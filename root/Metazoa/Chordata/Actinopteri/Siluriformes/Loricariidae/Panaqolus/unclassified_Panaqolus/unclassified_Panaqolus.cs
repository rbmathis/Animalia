using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Panaqolus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Panaqolus.unclassified_Panaqolus;

/// <summary>
/// Abstract class for unclassified Panaqolus (no rank).
/// NCBI TaxId: 2632805
/// </summary>
public abstract class unclassified_Panaqolus : Panaqolus, Iunclassified_Panaqolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Panaqolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632805;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Panaqolus";
}
