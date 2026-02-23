using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae.unclassified_Anabantidae;

/// <summary>
/// Abstract class for unclassified Anabantidae (no rank).
/// NCBI TaxId: 1881592
/// </summary>
public abstract class unclassified_Anabantidae : Anabantidae, Iunclassified_Anabantidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anabantidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1881592;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anabantidae";
}
