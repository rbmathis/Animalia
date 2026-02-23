using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Astyanacinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Astyanacinus.unclassified_Astyanacinus;

/// <summary>
/// Abstract class for unclassified Astyanacinus (no rank).
/// NCBI TaxId: 2621311
/// </summary>
public abstract class unclassified_Astyanacinus : Astyanacinus, Iunclassified_Astyanacinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Astyanacinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621311;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Astyanacinus";
}
