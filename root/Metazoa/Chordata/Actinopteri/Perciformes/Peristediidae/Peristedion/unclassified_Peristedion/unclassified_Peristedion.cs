using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Peristediidae.Peristedion;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Peristediidae.Peristedion.unclassified_Peristedion;

/// <summary>
/// Abstract class for unclassified Peristedion (no rank).
/// NCBI TaxId: 2643473
/// </summary>
public abstract class unclassified_Peristedion : Peristedion, Iunclassified_Peristedion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Peristedion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643473;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Peristedion";
}
