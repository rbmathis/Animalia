using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Thamnaconus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Thamnaconus.unclassified_Thamnaconus;

/// <summary>
/// Abstract class for unclassified Thamnaconus (no rank).
/// NCBI TaxId: 2872550
/// </summary>
public abstract class unclassified_Thamnaconus : Thamnaconus, Iunclassified_Thamnaconus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thamnaconus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2872550;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thamnaconus";
}
