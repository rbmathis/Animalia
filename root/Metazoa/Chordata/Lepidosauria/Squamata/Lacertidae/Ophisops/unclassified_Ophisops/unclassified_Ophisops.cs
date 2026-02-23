using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Ophisops;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Ophisops.unclassified_Ophisops;

/// <summary>
/// Abstract class for unclassified Ophisops (no rank).
/// NCBI TaxId: 3049139
/// </summary>
public abstract class unclassified_Ophisops : Ophisops, Iunclassified_Ophisops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ophisops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3049139;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ophisops";
}
