using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Dyscophus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Dyscophus.unclassified_Dyscophus;

/// <summary>
/// Abstract class for unclassified Dyscophus (no rank).
/// NCBI TaxId: 2881009
/// </summary>
public abstract class unclassified_Dyscophus : Dyscophus, Iunclassified_Dyscophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dyscophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2881009;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dyscophus";
}
