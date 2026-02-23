using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Nematalosa;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Nematalosa.unclassified_Nematalosa;

/// <summary>
/// Abstract class for unclassified Nematalosa (no rank).
/// NCBI TaxId: 2625224
/// </summary>
public abstract class unclassified_Nematalosa : Nematalosa, Iunclassified_Nematalosa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nematalosa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625224;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nematalosa";
}
