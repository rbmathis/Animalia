using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Norops;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Norops.unclassified_Norops;

/// <summary>
/// Abstract class for unclassified Norops (no rank).
/// NCBI TaxId: 3467882
/// </summary>
public abstract class unclassified_Norops : Norops, Iunclassified_Norops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Norops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3467882;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Norops";
}
