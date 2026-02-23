using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Leporinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Leporinus.unclassified_Leporinus;

/// <summary>
/// Abstract class for unclassified Leporinus (no rank).
/// NCBI TaxId: 2619804
/// </summary>
public abstract class unclassified_Leporinus : Leporinus, Iunclassified_Leporinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leporinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619804;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leporinus";
}
