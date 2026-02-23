using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Chlorocebus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Chlorocebus.unclassified_Chlorocebus;

/// <summary>
/// Abstract class for unclassified Chlorocebus (no rank).
/// NCBI TaxId: 2685534
/// </summary>
public abstract class unclassified_Chlorocebus : Chlorocebus, Iunclassified_Chlorocebus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chlorocebus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685534;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chlorocebus";
}
