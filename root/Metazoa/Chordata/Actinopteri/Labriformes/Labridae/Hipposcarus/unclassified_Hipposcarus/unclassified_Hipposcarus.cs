using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Hipposcarus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Hipposcarus.unclassified_Hipposcarus;

/// <summary>
/// Abstract class for unclassified Hipposcarus (no rank).
/// NCBI TaxId: 2624885
/// </summary>
public abstract class unclassified_Hipposcarus : Hipposcarus, Iunclassified_Hipposcarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hipposcarus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624885;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hipposcarus";
}
