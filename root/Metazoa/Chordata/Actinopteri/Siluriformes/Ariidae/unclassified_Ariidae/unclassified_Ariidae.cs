using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.unclassified_Ariidae;

/// <summary>
/// Abstract class for unclassified Ariidae (no rank).
/// NCBI TaxId: 2651602
/// </summary>
public abstract class unclassified_Ariidae : Ariidae, Iunclassified_Ariidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ariidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2651602;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ariidae";
}
