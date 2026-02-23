using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.unclassified_Notacanthiformes;

/// <summary>
/// Abstract class for unclassified Notacanthiformes (no rank).
/// NCBI TaxId: 727488
/// </summary>
public abstract class unclassified_Notacanthiformes : Notacanthiformes, Iunclassified_Notacanthiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Notacanthiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727488;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Notacanthiformes";
}
