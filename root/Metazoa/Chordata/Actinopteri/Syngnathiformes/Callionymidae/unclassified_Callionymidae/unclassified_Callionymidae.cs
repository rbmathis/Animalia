using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.unclassified_Callionymidae;

/// <summary>
/// Abstract class for unclassified Callionymidae (no rank).
/// NCBI TaxId: 1647123
/// </summary>
public abstract class unclassified_Callionymidae : Callionymidae, Iunclassified_Callionymidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Callionymidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1647123;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Callionymidae";
}
