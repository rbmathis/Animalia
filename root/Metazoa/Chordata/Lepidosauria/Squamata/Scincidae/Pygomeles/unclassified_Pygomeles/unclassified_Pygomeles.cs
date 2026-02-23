using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Pygomeles;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Pygomeles.unclassified_Pygomeles;

/// <summary>
/// Abstract class for unclassified Pygomeles (no rank).
/// NCBI TaxId: 2761124
/// </summary>
public abstract class unclassified_Pygomeles : Pygomeles, Iunclassified_Pygomeles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pygomeles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2761124;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pygomeles";
}
