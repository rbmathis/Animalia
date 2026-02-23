using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Hara;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Hara.unclassified_Hara;

/// <summary>
/// Abstract class for unclassified Hara (no rank).
/// NCBI TaxId: 2634743
/// </summary>
public abstract class unclassified_Hara : Hara, Iunclassified_Hara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634743;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hara";
}
