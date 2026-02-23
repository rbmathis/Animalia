using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.Lactoria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.Lactoria.unclassified_Lactoria;

/// <summary>
/// Abstract class for unclassified Lactoria (no rank).
/// NCBI TaxId: 2990211
/// </summary>
public abstract class unclassified_Lactoria : Lactoria, Iunclassified_Lactoria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lactoria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2990211;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lactoria";
}
