using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Lestrolepis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Lestrolepis.unclassified_Lestrolepis;

/// <summary>
/// Abstract class for unclassified Lestrolepis (no rank).
/// NCBI TaxId: 2620121
/// </summary>
public abstract class unclassified_Lestrolepis : Lestrolepis, Iunclassified_Lestrolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lestrolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620121;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lestrolepis";
}
