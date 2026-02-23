using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Helicops;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Helicops.unclassified_Helicops;

/// <summary>
/// Abstract class for unclassified Helicops (no rank).
/// NCBI TaxId: 2644501
/// </summary>
public abstract class unclassified_Helicops : Helicops, Iunclassified_Helicops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Helicops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644501;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Helicops";
}
