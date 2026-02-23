using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Colobus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Colobus.unclassified_Colobus;

/// <summary>
/// Abstract class for unclassified Colobus (no rank).
/// NCBI TaxId: 2618863
/// </summary>
public abstract class unclassified_Colobus : Colobus, Iunclassified_Colobus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Colobus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618863;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Colobus";
}
