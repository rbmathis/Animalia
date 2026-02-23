using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Homonota;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Homonota.unclassified_Homonota;

/// <summary>
/// Abstract class for unclassified Homonota (no rank).
/// NCBI TaxId: 2832469
/// </summary>
public abstract class unclassified_Homonota : Homonota, Iunclassified_Homonota
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Homonota";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2832469;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Homonota";
}
