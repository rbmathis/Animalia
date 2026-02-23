using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.unclassified_Bathylagidae;

/// <summary>
/// Abstract class for unclassified Bathylagidae (no rank).
/// NCBI TaxId: 2726632
/// </summary>
public abstract class unclassified_Bathylagidae : Bathylagidae, Iunclassified_Bathylagidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathylagidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726632;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathylagidae";
}
