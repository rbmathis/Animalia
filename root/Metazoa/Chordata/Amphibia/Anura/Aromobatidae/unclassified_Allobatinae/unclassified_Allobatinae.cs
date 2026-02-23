using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.unclassified_Allobatinae;

/// <summary>
/// Abstract class for unclassified Allobatinae (no rank).
/// NCBI TaxId: 3402669
/// </summary>
public abstract class unclassified_Allobatinae : Aromobatidae, Iunclassified_Allobatinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Allobatinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3402669;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Allobatinae";
}
