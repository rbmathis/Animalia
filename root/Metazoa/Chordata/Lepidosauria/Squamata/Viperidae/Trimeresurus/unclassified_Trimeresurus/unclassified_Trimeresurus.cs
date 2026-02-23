using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Trimeresurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Trimeresurus.unclassified_Trimeresurus;

/// <summary>
/// Abstract class for unclassified Trimeresurus (no rank).
/// NCBI TaxId: 2633335
/// </summary>
public abstract class unclassified_Trimeresurus : Trimeresurus, Iunclassified_Trimeresurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trimeresurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633335;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trimeresurus";
}
