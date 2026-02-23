using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Bathyanthias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Bathyanthias.unclassified_Bathyanthias;

/// <summary>
/// Abstract class for unclassified Bathyanthias (no rank).
/// NCBI TaxId: 2633997
/// </summary>
public abstract class unclassified_Bathyanthias : Bathyanthias, Iunclassified_Bathyanthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathyanthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633997;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathyanthias";
}
