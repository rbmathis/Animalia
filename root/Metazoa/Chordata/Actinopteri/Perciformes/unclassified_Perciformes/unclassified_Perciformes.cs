using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.unclassified_Perciformes;

/// <summary>
/// Abstract class for unclassified Perciformes (no rank).
/// NCBI TaxId: 721884
/// </summary>
public abstract class unclassified_Perciformes : Perciformes, Iunclassified_Perciformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Perciformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 721884;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Perciformes";
}
