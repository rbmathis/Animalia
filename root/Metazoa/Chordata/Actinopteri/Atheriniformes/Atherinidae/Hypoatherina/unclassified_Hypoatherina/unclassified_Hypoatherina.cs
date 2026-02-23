using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Hypoatherina;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Hypoatherina.unclassified_Hypoatherina;

/// <summary>
/// Abstract class for unclassified Hypoatherina (no rank).
/// NCBI TaxId: 2812618
/// </summary>
public abstract class unclassified_Hypoatherina : Hypoatherina, Iunclassified_Hypoatherina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypoatherina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2812618;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypoatherina";
}
