using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Teratoscincus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Teratoscincus.unclassified_Teratoscincus;

/// <summary>
/// Abstract class for unclassified Teratoscincus (no rank).
/// NCBI TaxId: 2639035
/// </summary>
public abstract class unclassified_Teratoscincus : Teratoscincus, Iunclassified_Teratoscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Teratoscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639035;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Teratoscincus";
}
