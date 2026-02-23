using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Harttia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Harttia.unclassified_Harttia;

/// <summary>
/// Abstract class for unclassified Harttia (no rank).
/// NCBI TaxId: 2621289
/// </summary>
public abstract class unclassified_Harttia : Harttia, Iunclassified_Harttia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Harttia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621289;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Harttia";
}
