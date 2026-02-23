using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Leiolopisma;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Leiolopisma.unclassified_Leiolopisma;

/// <summary>
/// Abstract class for unclassified Leiolopisma (no rank).
/// NCBI TaxId: 2645679
/// </summary>
public abstract class unclassified_Leiolopisma : Leiolopisma, Iunclassified_Leiolopisma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leiolopisma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645679;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leiolopisma";
}
