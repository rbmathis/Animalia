using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.unclassified_Gadiformes;

/// <summary>
/// Abstract class for unclassified Gadiformes (no rank).
/// NCBI TaxId: 723962
/// </summary>
public abstract class unclassified_Gadiformes : Gadiformes, Iunclassified_Gadiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gadiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 723962;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gadiformes";
}
