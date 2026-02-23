using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.unclassified_Trichiuridae;

/// <summary>
/// Abstract class for unclassified Trichiuridae (no rank).
/// NCBI TaxId: 1780186
/// </summary>
public abstract class unclassified_Trichiuridae : Trichiuridae, Iunclassified_Trichiuridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trichiuridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1780186;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trichiuridae";
}
