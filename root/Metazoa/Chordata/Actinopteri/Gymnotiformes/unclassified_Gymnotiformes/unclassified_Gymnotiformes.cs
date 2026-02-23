using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.unclassified_Gymnotiformes;

/// <summary>
/// Abstract class for unclassified Gymnotiformes (no rank).
/// NCBI TaxId: 740688
/// </summary>
public abstract class unclassified_Gymnotiformes : Gymnotiformes, Iunclassified_Gymnotiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gymnotiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 740688;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gymnotiformes";
}
