using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gaidropsaridae.Gaidropsarus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gaidropsaridae.Gaidropsarus.unclassified_Gaidropsarus;

/// <summary>
/// Abstract class for unclassified Gaidropsarus (no rank).
/// NCBI TaxId: 2633560
/// </summary>
public abstract class unclassified_Gaidropsarus : Gaidropsarus, Iunclassified_Gaidropsarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gaidropsarus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633560;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gaidropsarus";
}
