using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Gracilinanus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Gracilinanus.unclassified_Gracilinanus;

/// <summary>
/// Abstract class for unclassified Gracilinanus (no rank).
/// NCBI TaxId: 2638496
/// </summary>
public abstract class unclassified_Gracilinanus : Gracilinanus, Iunclassified_Gracilinanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gracilinanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638496;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gracilinanus";
}
