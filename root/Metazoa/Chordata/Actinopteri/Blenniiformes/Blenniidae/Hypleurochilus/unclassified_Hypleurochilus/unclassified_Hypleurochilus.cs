using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Hypleurochilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Hypleurochilus.unclassified_Hypleurochilus;

/// <summary>
/// Abstract class for unclassified Hypleurochilus (no rank).
/// NCBI TaxId: 2624423
/// </summary>
public abstract class unclassified_Hypleurochilus : Hypleurochilus, Iunclassified_Hypleurochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypleurochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624423;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypleurochilus";
}
