using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae.Chilatherina;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae.Chilatherina.unclassified_Chilatherina;

/// <summary>
/// Abstract class for unclassified Chilatherina (no rank).
/// NCBI TaxId: 2639334
/// </summary>
public abstract class unclassified_Chilatherina : Chilatherina, Iunclassified_Chilatherina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chilatherina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639334;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chilatherina";
}
