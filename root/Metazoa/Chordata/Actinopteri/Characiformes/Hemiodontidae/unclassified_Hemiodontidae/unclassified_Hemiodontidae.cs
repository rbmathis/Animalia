using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae.unclassified_Hemiodontidae;

/// <summary>
/// Abstract class for unclassified Hemiodontidae (no rank).
/// NCBI TaxId: 3101851
/// </summary>
public abstract class unclassified_Hemiodontidae : Hemiodontidae, Iunclassified_Hemiodontidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemiodontidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101851;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemiodontidae";
}
