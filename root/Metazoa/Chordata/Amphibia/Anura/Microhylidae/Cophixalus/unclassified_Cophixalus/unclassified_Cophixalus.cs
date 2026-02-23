using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Cophixalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Cophixalus.unclassified_Cophixalus;

/// <summary>
/// Abstract class for unclassified Cophixalus (no rank).
/// NCBI TaxId: 2609358
/// </summary>
public abstract class unclassified_Cophixalus : Cophixalus, Iunclassified_Cophixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cophixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609358;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cophixalus";
}
