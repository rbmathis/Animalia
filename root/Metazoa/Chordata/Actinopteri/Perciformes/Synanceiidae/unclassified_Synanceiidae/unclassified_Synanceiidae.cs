using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.unclassified_Synanceiidae;

/// <summary>
/// Abstract class for unclassified Synanceiidae (no rank).
/// NCBI TaxId: 1781136
/// </summary>
public abstract class unclassified_Synanceiidae : Synanceiidae, Iunclassified_Synanceiidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Synanceiidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1781136;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Synanceiidae";
}
