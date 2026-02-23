using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae.unclassified_Synodontidae;

/// <summary>
/// Abstract class for unclassified Synodontidae (no rank).
/// NCBI TaxId: 1182922
/// </summary>
public abstract class unclassified_Synodontidae : Synodontidae, Iunclassified_Synodontidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Synodontidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182922;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Synodontidae";
}
