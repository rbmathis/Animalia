using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Cociella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Cociella.unclassified_Cociella;

/// <summary>
/// Abstract class for unclassified Cociella (no rank).
/// NCBI TaxId: 2618136
/// </summary>
public abstract class unclassified_Cociella : Cociella, Iunclassified_Cociella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cociella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618136;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cociella";
}
