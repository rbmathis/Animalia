using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zenionidae.Zenion;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zenionidae.Zenion.unclassified_Zenion;

/// <summary>
/// Abstract class for unclassified Zenion (no rank).
/// NCBI TaxId: 2640557
/// </summary>
public abstract class unclassified_Zenion : Zenion, Iunclassified_Zenion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zenion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640557;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zenion";
}
