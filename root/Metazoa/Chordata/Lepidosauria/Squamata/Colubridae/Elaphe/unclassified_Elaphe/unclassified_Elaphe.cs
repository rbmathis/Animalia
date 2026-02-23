using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Elaphe;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Elaphe.unclassified_Elaphe;

/// <summary>
/// Abstract class for unclassified Elaphe (no rank).
/// NCBI TaxId: 2645415
/// </summary>
public abstract class unclassified_Elaphe : Elaphe, Iunclassified_Elaphe
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Elaphe";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645415;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Elaphe";
}
