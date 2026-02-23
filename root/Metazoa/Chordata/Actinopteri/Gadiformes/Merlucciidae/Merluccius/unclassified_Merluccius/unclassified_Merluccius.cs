using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Merlucciidae.Merluccius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Merlucciidae.Merluccius.unclassified_Merluccius;

/// <summary>
/// Abstract class for unclassified Merluccius (no rank).
/// NCBI TaxId: 2625009
/// </summary>
public abstract class unclassified_Merluccius : Merluccius, Iunclassified_Merluccius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Merluccius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625009;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Merluccius";
}
