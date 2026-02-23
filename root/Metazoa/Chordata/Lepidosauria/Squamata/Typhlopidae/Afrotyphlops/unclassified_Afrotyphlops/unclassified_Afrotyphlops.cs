using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Afrotyphlops;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Afrotyphlops.unclassified_Afrotyphlops;

/// <summary>
/// Abstract class for unclassified Afrotyphlops (no rank).
/// NCBI TaxId: 2627681
/// </summary>
public abstract class unclassified_Afrotyphlops : Afrotyphlops, Iunclassified_Afrotyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Afrotyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627681;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Afrotyphlops";
}
