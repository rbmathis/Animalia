using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.unclassified_Mugiliformes;

/// <summary>
/// Abstract class for unclassified Mugiliformes (no rank).
/// NCBI TaxId: 948975
/// </summary>
public abstract class unclassified_Mugiliformes : Mugiliformes, Iunclassified_Mugiliformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mugiliformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 948975;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mugiliformes";
}
