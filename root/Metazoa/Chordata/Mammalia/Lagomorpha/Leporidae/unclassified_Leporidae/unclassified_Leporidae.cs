using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.unclassified_Leporidae;

/// <summary>
/// Abstract class for unclassified Leporidae (no rank).
/// NCBI TaxId: 887055
/// </summary>
public abstract class unclassified_Leporidae : Leporidae, Iunclassified_Leporidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leporidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 887055;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leporidae";
}
