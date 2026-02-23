using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cheirogaleidae.Microcebus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cheirogaleidae.Microcebus.unclassified_Microcebus;

/// <summary>
/// Abstract class for unclassified Microcebus (no rank).
/// NCBI TaxId: 2630091
/// </summary>
public abstract class unclassified_Microcebus : Microcebus, Iunclassified_Microcebus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microcebus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630091;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microcebus";
}
