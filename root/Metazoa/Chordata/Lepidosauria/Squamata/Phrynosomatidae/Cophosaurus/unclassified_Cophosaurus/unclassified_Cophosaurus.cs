using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Cophosaurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Cophosaurus.unclassified_Cophosaurus;

/// <summary>
/// Abstract class for unclassified Cophosaurus (no rank).
/// NCBI TaxId: 3452248
/// </summary>
public abstract class unclassified_Cophosaurus : Cophosaurus, Iunclassified_Cophosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cophosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3452248;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cophosaurus";
}
