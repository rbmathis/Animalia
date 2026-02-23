using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Amazonsprattus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Amazonsprattus.unclassified_Amazonsprattus;

/// <summary>
/// Abstract class for unclassified Amazonsprattus (no rank).
/// NCBI TaxId: 2629471
/// </summary>
public abstract class unclassified_Amazonsprattus : Amazonsprattus, Iunclassified_Amazonsprattus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amazonsprattus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629471;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amazonsprattus";
}
