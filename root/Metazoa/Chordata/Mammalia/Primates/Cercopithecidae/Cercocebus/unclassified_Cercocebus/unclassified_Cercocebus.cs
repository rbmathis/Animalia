using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Cercocebus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Cercocebus.unclassified_Cercocebus;

/// <summary>
/// Abstract class for unclassified Cercocebus (no rank).
/// NCBI TaxId: 2959323
/// </summary>
public abstract class unclassified_Cercocebus : Cercocebus, Iunclassified_Cercocebus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cercocebus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2959323;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cercocebus";
}
