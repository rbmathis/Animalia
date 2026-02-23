using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Lycodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Lycodes.unclassified_Lycodes;

/// <summary>
/// Abstract class for unclassified Lycodes (no rank).
/// NCBI TaxId: 2618903
/// </summary>
public abstract class unclassified_Lycodes : Lycodes, Iunclassified_Lycodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lycodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618903;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lycodes";
}
