using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Luciosoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Luciosoma.unclassified_Luciosoma;

/// <summary>
/// Abstract class for unclassified Luciosoma (no rank).
/// NCBI TaxId: 2648740
/// </summary>
public abstract class unclassified_Luciosoma : Luciosoma, Iunclassified_Luciosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Luciosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648740;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Luciosoma";
}
