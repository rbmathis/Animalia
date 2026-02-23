using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Apletodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Apletodon.unclassified_Apletodon;

/// <summary>
/// Abstract class for unclassified Apletodon (no rank).
/// NCBI TaxId: 2635115
/// </summary>
public abstract class unclassified_Apletodon : Apletodon, Iunclassified_Apletodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Apletodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635115;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Apletodon";
}
