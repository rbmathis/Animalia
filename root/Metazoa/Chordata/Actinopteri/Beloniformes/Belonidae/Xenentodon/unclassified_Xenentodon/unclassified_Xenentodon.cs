using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Xenentodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Xenentodon.unclassified_Xenentodon;

/// <summary>
/// Abstract class for unclassified Xenentodon (no rank).
/// NCBI TaxId: 2632000
/// </summary>
public abstract class unclassified_Xenentodon : Xenentodon, Iunclassified_Xenentodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Xenentodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632000;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Xenentodon";
}
