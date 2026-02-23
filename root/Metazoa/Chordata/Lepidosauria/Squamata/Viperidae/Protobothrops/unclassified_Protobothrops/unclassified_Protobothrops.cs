using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Protobothrops;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Protobothrops.unclassified_Protobothrops;

/// <summary>
/// Abstract class for unclassified Protobothrops (no rank).
/// NCBI TaxId: 2629261
/// </summary>
public abstract class unclassified_Protobothrops : Protobothrops, Iunclassified_Protobothrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Protobothrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629261;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Protobothrops";
}
