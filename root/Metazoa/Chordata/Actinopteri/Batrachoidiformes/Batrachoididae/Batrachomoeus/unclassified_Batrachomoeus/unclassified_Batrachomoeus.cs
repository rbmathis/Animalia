using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Batrachomoeus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Batrachomoeus.unclassified_Batrachomoeus;

/// <summary>
/// Abstract class for unclassified Batrachomoeus (no rank).
/// NCBI TaxId: 2672453
/// </summary>
public abstract class unclassified_Batrachomoeus : Batrachomoeus, Iunclassified_Batrachomoeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Batrachomoeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2672453;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Batrachomoeus";
}
