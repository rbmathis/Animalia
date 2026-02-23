using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Leporacanthicus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Leporacanthicus.unclassified_Leporacanthicus;

/// <summary>
/// Abstract class for unclassified Leporacanthicus (no rank).
/// NCBI TaxId: 2624948
/// </summary>
public abstract class unclassified_Leporacanthicus : Leporacanthicus, Iunclassified_Leporacanthicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leporacanthicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624948;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leporacanthicus";
}
