using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.unclassified_Chamaeleonidae;

/// <summary>
/// Abstract class for unclassified Chamaeleonidae (no rank).
/// NCBI TaxId: 2837585
/// </summary>
public abstract class unclassified_Chamaeleonidae : Chamaeleonidae, Iunclassified_Chamaeleonidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chamaeleonidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2837585;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chamaeleonidae";
}
