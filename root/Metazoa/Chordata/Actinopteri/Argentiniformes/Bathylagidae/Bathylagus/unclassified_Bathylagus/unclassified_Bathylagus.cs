using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Bathylagus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Bathylagus.unclassified_Bathylagus;

/// <summary>
/// Abstract class for unclassified Bathylagus (no rank).
/// NCBI TaxId: 2632229
/// </summary>
public abstract class unclassified_Bathylagus : Bathylagus, Iunclassified_Bathylagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathylagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632229;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathylagus";
}
