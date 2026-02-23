using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Ituglanis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Ituglanis.unclassified_Ituglanis;

/// <summary>
/// Abstract class for unclassified Ituglanis (no rank).
/// NCBI TaxId: 2626317
/// </summary>
public abstract class unclassified_Ituglanis : Ituglanis, Iunclassified_Ituglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ituglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626317;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ituglanis";
}
