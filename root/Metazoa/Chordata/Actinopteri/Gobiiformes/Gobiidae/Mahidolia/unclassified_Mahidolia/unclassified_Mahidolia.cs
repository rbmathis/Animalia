using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Mahidolia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Mahidolia.unclassified_Mahidolia;

/// <summary>
/// Abstract class for unclassified Mahidolia (no rank).
/// NCBI TaxId: 2641723
/// </summary>
public abstract class unclassified_Mahidolia : Mahidolia, Iunclassified_Mahidolia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mahidolia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641723;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mahidolia";
}
