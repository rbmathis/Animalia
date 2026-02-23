using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Phodopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Phodopus.unclassified_Phodopus;

/// <summary>
/// Abstract class for unclassified Phodopus (no rank).
/// NCBI TaxId: 2629528
/// </summary>
public abstract class unclassified_Phodopus : Phodopus, Iunclassified_Phodopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phodopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629528;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phodopus";
}
