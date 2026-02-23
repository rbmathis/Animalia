using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Nactus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Nactus.unclassified_Nactus;

/// <summary>
/// Abstract class for unclassified Nactus (no rank).
/// NCBI TaxId: 2627630
/// </summary>
public abstract class unclassified_Nactus : Nactus, Iunclassified_Nactus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nactus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627630;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nactus";
}
