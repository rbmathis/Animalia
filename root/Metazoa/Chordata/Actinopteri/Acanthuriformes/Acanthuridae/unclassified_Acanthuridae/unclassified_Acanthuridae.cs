using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.unclassified_Acanthuridae;

/// <summary>
/// Abstract class for unclassified Acanthuridae (no rank).
/// NCBI TaxId: 1647117
/// </summary>
public abstract class unclassified_Acanthuridae : Acanthuridae, Iunclassified_Acanthuridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acanthuridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1647117;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acanthuridae";
}
