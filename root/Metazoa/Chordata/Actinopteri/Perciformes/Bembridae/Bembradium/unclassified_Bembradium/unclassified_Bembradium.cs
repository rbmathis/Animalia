using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bembridae.Bembradium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bembridae.Bembradium.unclassified_Bembradium;

/// <summary>
/// Abstract class for unclassified Bembradium (no rank).
/// NCBI TaxId: 2622935
/// </summary>
public abstract class unclassified_Bembradium : Bembradium, Iunclassified_Bembradium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bembradium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622935;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bembradium";
}
