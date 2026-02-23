using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Rafetus;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Rafetus.unclassified_Rafetus;

/// <summary>
/// Abstract class for unclassified Rafetus (no rank).
/// NCBI TaxId: 2804322
/// </summary>
public abstract class unclassified_Rafetus : Rafetus, Iunclassified_Rafetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rafetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2804322;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rafetus";
}
