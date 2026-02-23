using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Nettastoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Nettastoma.unclassified_Nettastoma;

/// <summary>
/// Abstract class for unclassified Nettastoma (no rank).
/// NCBI TaxId: 2980720
/// </summary>
public abstract class unclassified_Nettastoma : Nettastoma, Iunclassified_Nettastoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nettastoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2980720;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nettastoma";
}
