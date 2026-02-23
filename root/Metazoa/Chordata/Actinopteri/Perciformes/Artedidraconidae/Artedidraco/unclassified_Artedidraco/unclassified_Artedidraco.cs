using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Artedidraconidae.Artedidraco;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Artedidraconidae.Artedidraco.unclassified_Artedidraco;

/// <summary>
/// Abstract class for unclassified Artedidraco (no rank).
/// NCBI TaxId: 2623721
/// </summary>
public abstract class unclassified_Artedidraco : Artedidraco, Iunclassified_Artedidraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Artedidraco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623721;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Artedidraco";
}
