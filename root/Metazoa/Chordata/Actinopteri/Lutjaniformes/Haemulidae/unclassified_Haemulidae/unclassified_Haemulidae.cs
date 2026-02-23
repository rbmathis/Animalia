using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.unclassified_Haemulidae;

/// <summary>
/// Abstract class for unclassified Haemulidae (no rank).
/// NCBI TaxId: 1182822
/// </summary>
public abstract class unclassified_Haemulidae : Haemulidae, Iunclassified_Haemulidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Haemulidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182822;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Haemulidae";
}
