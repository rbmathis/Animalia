using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Hemidactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Hemidactylus.unclassified_Hemidactylus;

/// <summary>
/// Abstract class for unclassified Hemidactylus (no rank).
/// NCBI TaxId: 2624212
/// </summary>
public abstract class unclassified_Hemidactylus : Hemidactylus, Iunclassified_Hemidactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemidactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624212;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemidactylus";
}
