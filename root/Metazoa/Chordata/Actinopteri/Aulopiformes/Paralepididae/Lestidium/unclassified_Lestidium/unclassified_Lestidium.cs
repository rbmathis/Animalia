using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Lestidium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Lestidium.unclassified_Lestidium;

/// <summary>
/// Abstract class for unclassified Lestidium (no rank).
/// NCBI TaxId: 3446433
/// </summary>
public abstract class unclassified_Lestidium : Lestidium, Iunclassified_Lestidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lestidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3446433;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lestidium";
}
