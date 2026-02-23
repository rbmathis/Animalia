using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Trachischium;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Trachischium.unclassified_Trachischium;

/// <summary>
/// Abstract class for unclassified Trachischium (no rank).
/// NCBI TaxId: 2677743
/// </summary>
public abstract class unclassified_Trachischium : Trachischium, Iunclassified_Trachischium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachischium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677743;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachischium";
}
