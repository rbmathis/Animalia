using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Channidae.Channa;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Channidae.Channa.unclassified_Channa;

/// <summary>
/// Abstract class for unclassified Channa (no rank).
/// NCBI TaxId: 2684940
/// </summary>
public abstract class unclassified_Channa : Channa, Iunclassified_Channa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Channa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2684940;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Channa";
}
