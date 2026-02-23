using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.unclassified_Syngnathiformes;

/// <summary>
/// Abstract class for unclassified Syngnathiformes (no rank).
/// NCBI TaxId: 725046
/// </summary>
public abstract class unclassified_Syngnathiformes : Syngnathiformes, Iunclassified_Syngnathiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Syngnathiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 725046;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Syngnathiformes";
}
