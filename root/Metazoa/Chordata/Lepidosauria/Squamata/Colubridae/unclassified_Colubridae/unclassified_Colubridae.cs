using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.unclassified_Colubridae;

/// <summary>
/// Abstract class for unclassified Colubridae (no rank).
/// NCBI TaxId: 2696280
/// </summary>
public abstract class unclassified_Colubridae : Colubridae, Iunclassified_Colubridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Colubridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696280;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Colubridae";
}
