using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Cynops;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Cynops.unclassified_Cynops;

/// <summary>
/// Abstract class for unclassified Cynops (no rank).
/// NCBI TaxId: 2859773
/// </summary>
public abstract class unclassified_Cynops : Cynops, Iunclassified_Cynops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cynops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2859773;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cynops";
}
