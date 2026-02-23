using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Bunopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Bunopus.unclassified_Bunopus;

/// <summary>
/// Abstract class for unclassified Bunopus (no rank).
/// NCBI TaxId: 2628781
/// </summary>
public abstract class unclassified_Bunopus : Bunopus, Iunclassified_Bunopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bunopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628781;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bunopus";
}
