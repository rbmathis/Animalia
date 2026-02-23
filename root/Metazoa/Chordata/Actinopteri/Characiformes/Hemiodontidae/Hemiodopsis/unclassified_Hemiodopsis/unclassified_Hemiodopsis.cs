using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae.Hemiodopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae.Hemiodopsis.unclassified_Hemiodopsis;

/// <summary>
/// Abstract class for unclassified Hemiodopsis (no rank).
/// NCBI TaxId: 2630124
/// </summary>
public abstract class unclassified_Hemiodopsis : Hemiodopsis, Iunclassified_Hemiodopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemiodopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630124;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemiodopsis";
}
