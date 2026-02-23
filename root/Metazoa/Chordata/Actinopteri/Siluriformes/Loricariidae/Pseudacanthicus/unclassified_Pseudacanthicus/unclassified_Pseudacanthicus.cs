using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudacanthicus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudacanthicus.unclassified_Pseudacanthicus;

/// <summary>
/// Abstract class for unclassified Pseudacanthicus (no rank).
/// NCBI TaxId: 2645077
/// </summary>
public abstract class unclassified_Pseudacanthicus : Pseudacanthicus, Iunclassified_Pseudacanthicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudacanthicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645077;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudacanthicus";
}
