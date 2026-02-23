using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.unclassified_Lagomorpha;

/// <summary>
/// Abstract class for unclassified Lagomorpha (no rank).
/// NCBI TaxId: 727868
/// </summary>
public abstract class unclassified_Lagomorpha : Lagomorpha, Iunclassified_Lagomorpha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lagomorpha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727868;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lagomorpha";
}
