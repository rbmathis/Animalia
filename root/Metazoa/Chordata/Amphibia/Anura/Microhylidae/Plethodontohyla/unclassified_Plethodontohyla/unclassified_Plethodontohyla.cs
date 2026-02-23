using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Plethodontohyla;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Plethodontohyla.unclassified_Plethodontohyla;

/// <summary>
/// Abstract class for unclassified Plethodontohyla (no rank).
/// NCBI TaxId: 2631583
/// </summary>
public abstract class unclassified_Plethodontohyla : Plethodontohyla, Iunclassified_Plethodontohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plethodontohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631583;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plethodontohyla";
}
