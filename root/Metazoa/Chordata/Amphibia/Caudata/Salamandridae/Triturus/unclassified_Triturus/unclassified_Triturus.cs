using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Triturus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Triturus.unclassified_Triturus;

/// <summary>
/// Abstract class for unclassified Triturus (no rank).
/// NCBI TaxId: 3459726
/// </summary>
public abstract class unclassified_Triturus : Triturus, Iunclassified_Triturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Triturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3459726;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Triturus";
}
