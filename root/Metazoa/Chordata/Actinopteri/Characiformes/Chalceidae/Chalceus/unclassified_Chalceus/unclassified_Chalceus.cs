using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Chalceidae.Chalceus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Chalceidae.Chalceus.unclassified_Chalceus;

/// <summary>
/// Abstract class for unclassified Chalceus (no rank).
/// NCBI TaxId: 2626551
/// </summary>
public abstract class unclassified_Chalceus : Chalceus, Iunclassified_Chalceus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chalceus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626551;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chalceus";
}
