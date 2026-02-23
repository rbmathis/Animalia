using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Scarus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Scarus.unclassified_Scarus;

/// <summary>
/// Abstract class for unclassified Scarus (no rank).
/// NCBI TaxId: 2617994
/// </summary>
public abstract class unclassified_Scarus : Scarus, Iunclassified_Scarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scarus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617994;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scarus";
}
