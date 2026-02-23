using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Callicebus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Callicebus.unclassified_Callicebus;

/// <summary>
/// Abstract class for unclassified Callicebus (no rank).
/// NCBI TaxId: 2627897
/// </summary>
public abstract class unclassified_Callicebus : Callicebus, Iunclassified_Callicebus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Callicebus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627897;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Callicebus";
}
