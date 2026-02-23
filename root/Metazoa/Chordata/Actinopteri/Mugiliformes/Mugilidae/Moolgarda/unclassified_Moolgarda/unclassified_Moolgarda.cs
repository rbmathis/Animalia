using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Moolgarda;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Moolgarda.unclassified_Moolgarda;

/// <summary>
/// Abstract class for unclassified Moolgarda (no rank).
/// NCBI TaxId: 2646997
/// </summary>
public abstract class unclassified_Moolgarda : Moolgarda, Iunclassified_Moolgarda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Moolgarda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646997;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Moolgarda";
}
