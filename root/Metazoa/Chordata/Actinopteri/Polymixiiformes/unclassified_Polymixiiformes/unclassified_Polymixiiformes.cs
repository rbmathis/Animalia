using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Polymixiiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Polymixiiformes.unclassified_Polymixiiformes;

/// <summary>
/// Abstract class for unclassified Polymixiiformes (no rank).
/// NCBI TaxId: 732569
/// </summary>
public abstract class unclassified_Polymixiiformes : Polymixiiformes, Iunclassified_Polymixiiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polymixiiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 732569;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polymixiiformes";
}
