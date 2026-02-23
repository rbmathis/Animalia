using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lobulia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lobulia.unclassified_Lobulia;

/// <summary>
/// Abstract class for unclassified Lobulia (no rank).
/// NCBI TaxId: 2855621
/// </summary>
public abstract class unclassified_Lobulia : Lobulia, Iunclassified_Lobulia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lobulia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2855621;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lobulia";
}
