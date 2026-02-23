using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Ctenochaetus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Ctenochaetus.unclassified_Ctenochaetus;

/// <summary>
/// Abstract class for unclassified Ctenochaetus (no rank).
/// NCBI TaxId: 2642222
/// </summary>
public abstract class unclassified_Ctenochaetus : Ctenochaetus, Iunclassified_Ctenochaetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ctenochaetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642222;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ctenochaetus";
}
