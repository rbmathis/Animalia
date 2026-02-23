using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Bathylagoides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Bathylagoides.unclassified_Bathylagoides;

/// <summary>
/// Abstract class for unclassified Bathylagoides (no rank).
/// NCBI TaxId: 2632131
/// </summary>
public abstract class unclassified_Bathylagoides : Bathylagoides, Iunclassified_Bathylagoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathylagoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632131;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathylagoides";
}
