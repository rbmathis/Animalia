using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Stumpffia;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Stumpffia.unclassified_Stumpffia;

/// <summary>
/// Abstract class for unclassified Stumpffia (no rank).
/// NCBI TaxId: 2641922
/// </summary>
public abstract class unclassified_Stumpffia : Stumpffia, Iunclassified_Stumpffia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stumpffia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641922;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stumpffia";
}
