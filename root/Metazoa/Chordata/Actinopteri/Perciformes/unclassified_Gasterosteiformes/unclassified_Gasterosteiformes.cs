using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.unclassified_Gasterosteiformes;

/// <summary>
/// Abstract class for unclassified Gasterosteiformes (no rank).
/// NCBI TaxId: 725928
/// </summary>
public abstract class unclassified_Gasterosteiformes : Perciformes, Iunclassified_Gasterosteiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gasterosteiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 725928;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gasterosteiformes";
}
