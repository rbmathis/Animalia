using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae.Monacoa;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae.Monacoa.unclassified_Monacoa;

/// <summary>
/// Abstract class for unclassified Monacoa (no rank).
/// NCBI TaxId: 2628819
/// </summary>
public abstract class unclassified_Monacoa : Monacoa, Iunclassified_Monacoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Monacoa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628819;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Monacoa";
}
