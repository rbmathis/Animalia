using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Dendropsophus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Dendropsophus.unclassified_Dendropsophus;

/// <summary>
/// Abstract class for unclassified Dendropsophus (no rank).
/// NCBI TaxId: 2618884
/// </summary>
public abstract class unclassified_Dendropsophus : Dendropsophus, Iunclassified_Dendropsophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dendropsophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618884;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dendropsophus";
}
