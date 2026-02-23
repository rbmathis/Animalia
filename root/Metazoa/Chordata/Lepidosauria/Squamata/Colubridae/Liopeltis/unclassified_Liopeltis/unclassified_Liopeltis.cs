using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Liopeltis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Liopeltis.unclassified_Liopeltis;

/// <summary>
/// Abstract class for unclassified Liopeltis (no rank).
/// NCBI TaxId: 2622572
/// </summary>
public abstract class unclassified_Liopeltis : Liopeltis, Iunclassified_Liopeltis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Liopeltis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622572;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Liopeltis";
}
