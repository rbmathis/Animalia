using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Eugongylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Eugongylus.unclassified_Eugongylus;

/// <summary>
/// Abstract class for unclassified Eugongylus (no rank).
/// NCBI TaxId: 2638162
/// </summary>
public abstract class unclassified_Eugongylus : Eugongylus, Iunclassified_Eugongylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eugongylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638162;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eugongylus";
}
