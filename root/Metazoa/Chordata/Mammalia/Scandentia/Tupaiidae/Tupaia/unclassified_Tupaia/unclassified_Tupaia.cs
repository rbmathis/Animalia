using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Scandentia.Tupaiidae.Tupaia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Scandentia.Tupaiidae.Tupaia.unclassified_Tupaia;

/// <summary>
/// Abstract class for unclassified Tupaia (no rank).
/// NCBI TaxId: 2638347
/// </summary>
public abstract class unclassified_Tupaia : Tupaia, Iunclassified_Tupaia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tupaia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638347;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tupaia";
}
