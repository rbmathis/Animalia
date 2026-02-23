using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Artedidraconidae.Pogonophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Artedidraconidae.Pogonophryne.unclassified_Pogonophryne;

/// <summary>
/// Abstract class for unclassified Pogonophryne (no rank).
/// NCBI TaxId: 2630410
/// </summary>
public abstract class unclassified_Pogonophryne : Pogonophryne, Iunclassified_Pogonophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pogonophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630410;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pogonophryne";
}
