using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Chiropterotriton;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Chiropterotriton.unclassified_Chiropterotriton;

/// <summary>
/// Abstract class for unclassified Chiropterotriton (no rank).
/// NCBI TaxId: 2645304
/// </summary>
public abstract class unclassified_Chiropterotriton : Chiropterotriton, Iunclassified_Chiropterotriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chiropterotriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645304;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chiropterotriton";
}
