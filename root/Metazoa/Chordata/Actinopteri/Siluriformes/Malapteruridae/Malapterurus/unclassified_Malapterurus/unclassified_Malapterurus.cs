using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Malapteruridae.Malapterurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Malapteruridae.Malapterurus.unclassified_Malapterurus;

/// <summary>
/// Abstract class for unclassified Malapterurus (no rank).
/// NCBI TaxId: 2622528
/// </summary>
public abstract class unclassified_Malapterurus : Malapterurus, Iunclassified_Malapterurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Malapterurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622528;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Malapterurus";
}
