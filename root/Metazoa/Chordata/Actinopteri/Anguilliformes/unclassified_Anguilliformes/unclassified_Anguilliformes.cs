using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.unclassified_Anguilliformes;

/// <summary>
/// Abstract class for unclassified Anguilliformes (no rank).
/// NCBI TaxId: 720872
/// </summary>
public abstract class unclassified_Anguilliformes : Anguilliformes, Iunclassified_Anguilliformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anguilliformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 720872;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anguilliformes";
}
