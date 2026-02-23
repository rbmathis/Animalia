using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Brachymeles;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Brachymeles.unclassified_Brachymeles;

/// <summary>
/// Abstract class for unclassified Brachymeles (no rank).
/// NCBI TaxId: 2685444
/// </summary>
public abstract class unclassified_Brachymeles : Brachymeles, Iunclassified_Brachymeles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brachymeles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685444;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brachymeles";
}
