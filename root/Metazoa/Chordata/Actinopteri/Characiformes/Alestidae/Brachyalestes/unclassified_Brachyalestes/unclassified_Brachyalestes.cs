using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Brachyalestes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Brachyalestes.unclassified_Brachyalestes;

/// <summary>
/// Abstract class for unclassified Brachyalestes (no rank).
/// NCBI TaxId: 3088367
/// </summary>
public abstract class unclassified_Brachyalestes : Brachyalestes, Iunclassified_Brachyalestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brachyalestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3088367;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brachyalestes";
}
