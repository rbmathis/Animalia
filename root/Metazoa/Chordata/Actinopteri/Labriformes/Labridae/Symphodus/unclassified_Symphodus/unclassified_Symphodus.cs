using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Symphodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Symphodus.unclassified_Symphodus;

/// <summary>
/// Abstract class for unclassified Symphodus (no rank).
/// NCBI TaxId: 3472364
/// </summary>
public abstract class unclassified_Symphodus : Symphodus, Iunclassified_Symphodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Symphodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3472364;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Symphodus";
}
