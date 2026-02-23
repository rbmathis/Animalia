using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Desmognathus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Desmognathus.unclassified_Desmognathus;

/// <summary>
/// Abstract class for unclassified Desmognathus (no rank).
/// NCBI TaxId: 2636894
/// </summary>
public abstract class unclassified_Desmognathus : Desmognathus, Iunclassified_Desmognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Desmognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636894;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Desmognathus";
}
