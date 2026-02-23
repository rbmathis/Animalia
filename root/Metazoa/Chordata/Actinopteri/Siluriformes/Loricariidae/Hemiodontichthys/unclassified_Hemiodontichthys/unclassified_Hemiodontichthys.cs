using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hemiodontichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hemiodontichthys.unclassified_Hemiodontichthys;

/// <summary>
/// Abstract class for unclassified Hemiodontichthys (no rank).
/// NCBI TaxId: 2645648
/// </summary>
public abstract class unclassified_Hemiodontichthys : Hemiodontichthys, Iunclassified_Hemiodontichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemiodontichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645648;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemiodontichthys";
}
