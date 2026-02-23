using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.unclassified_Cottoidei;

/// <summary>
/// Abstract class for unclassified Cottoidei (no rank).
/// NCBI TaxId: 183719
/// </summary>
public abstract class unclassified_Cottoidei : Perciformes, Iunclassified_Cottoidei
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cottoidei";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183719;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cottoidei";
}
