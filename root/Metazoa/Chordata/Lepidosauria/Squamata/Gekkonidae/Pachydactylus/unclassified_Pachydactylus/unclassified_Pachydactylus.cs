using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Pachydactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Pachydactylus.unclassified_Pachydactylus;

/// <summary>
/// Abstract class for unclassified Pachydactylus (no rank).
/// NCBI TaxId: 2623478
/// </summary>
public abstract class unclassified_Pachydactylus : Pachydactylus, Iunclassified_Pachydactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pachydactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623478;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pachydactylus";
}
