using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Sternoptyx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Sternoptyx.unclassified_Sternoptyx;

/// <summary>
/// Abstract class for unclassified Sternoptyx (no rank).
/// NCBI TaxId: 2645607
/// </summary>
public abstract class unclassified_Sternoptyx : Sternoptyx, Iunclassified_Sternoptyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sternoptyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645607;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sternoptyx";
}
