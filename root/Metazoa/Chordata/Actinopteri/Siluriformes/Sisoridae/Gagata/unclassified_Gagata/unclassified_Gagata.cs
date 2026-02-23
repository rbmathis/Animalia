using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Gagata;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Gagata.unclassified_Gagata;

/// <summary>
/// Abstract class for unclassified Gagata (no rank).
/// NCBI TaxId: 2620462
/// </summary>
public abstract class unclassified_Gagata : Gagata, Iunclassified_Gagata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gagata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620462;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gagata";
}
