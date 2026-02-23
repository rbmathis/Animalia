using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hisonotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hisonotus.unclassified_Hisonotus;

/// <summary>
/// Abstract class for unclassified Hisonotus (no rank).
/// NCBI TaxId: 2649659
/// </summary>
public abstract class unclassified_Hisonotus : Hisonotus, Iunclassified_Hisonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hisonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649659;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hisonotus";
}
