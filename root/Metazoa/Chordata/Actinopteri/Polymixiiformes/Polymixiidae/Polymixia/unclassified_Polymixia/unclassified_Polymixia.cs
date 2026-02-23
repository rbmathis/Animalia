using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Polymixiiformes.Polymixiidae.Polymixia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Polymixiiformes.Polymixiidae.Polymixia.unclassified_Polymixia;

/// <summary>
/// Abstract class for unclassified Polymixia (no rank).
/// NCBI TaxId: 2626460
/// </summary>
public abstract class unclassified_Polymixia : Polymixia, Iunclassified_Polymixia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polymixia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626460;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polymixia";
}
