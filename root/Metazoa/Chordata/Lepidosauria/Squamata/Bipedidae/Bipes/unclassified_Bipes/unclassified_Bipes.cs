using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Bipedidae.Bipes;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Bipedidae.Bipes.unclassified_Bipes;

/// <summary>
/// Abstract class for unclassified Bipes (no rank).
/// NCBI TaxId: 2630090
/// </summary>
public abstract class unclassified_Bipes : Bipes, Iunclassified_Bipes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bipes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630090;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bipes";
}
