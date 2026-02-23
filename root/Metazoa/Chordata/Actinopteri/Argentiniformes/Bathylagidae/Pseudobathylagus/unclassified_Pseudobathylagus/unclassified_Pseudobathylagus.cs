using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Pseudobathylagus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Pseudobathylagus.unclassified_Pseudobathylagus;

/// <summary>
/// Abstract class for unclassified Pseudobathylagus (no rank).
/// NCBI TaxId: 3106028
/// </summary>
public abstract class unclassified_Pseudobathylagus : Pseudobathylagus, Iunclassified_Pseudobathylagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudobathylagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3106028;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudobathylagus";
}
