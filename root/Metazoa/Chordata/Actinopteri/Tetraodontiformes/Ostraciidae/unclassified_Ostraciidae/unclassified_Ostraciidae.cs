using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.unclassified_Ostraciidae;

/// <summary>
/// Abstract class for unclassified Ostraciidae (no rank).
/// NCBI TaxId: 721883
/// </summary>
public abstract class unclassified_Ostraciidae : Ostraciidae, Iunclassified_Ostraciidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ostraciidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 721883;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ostraciidae";
}
