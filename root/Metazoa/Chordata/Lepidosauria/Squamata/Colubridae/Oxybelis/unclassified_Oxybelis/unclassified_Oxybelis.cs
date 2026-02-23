using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Oxybelis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Oxybelis.unclassified_Oxybelis;

/// <summary>
/// Abstract class for unclassified Oxybelis (no rank).
/// NCBI TaxId: 2876035
/// </summary>
public abstract class unclassified_Oxybelis : Oxybelis, Iunclassified_Oxybelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oxybelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2876035;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oxybelis";
}
