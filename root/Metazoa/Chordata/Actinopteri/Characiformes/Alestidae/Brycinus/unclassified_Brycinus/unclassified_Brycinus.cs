using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Brycinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Brycinus.unclassified_Brycinus;

/// <summary>
/// Abstract class for unclassified Brycinus (no rank).
/// NCBI TaxId: 2641490
/// </summary>
public abstract class unclassified_Brycinus : Brycinus, Iunclassified_Brycinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brycinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641490;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brycinus";
}
