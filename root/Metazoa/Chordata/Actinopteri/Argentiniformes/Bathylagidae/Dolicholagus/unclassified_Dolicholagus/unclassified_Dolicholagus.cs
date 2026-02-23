using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Dolicholagus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Bathylagidae.Dolicholagus.unclassified_Dolicholagus;

/// <summary>
/// Abstract class for unclassified Dolicholagus (no rank).
/// NCBI TaxId: 2639636
/// </summary>
public abstract class unclassified_Dolicholagus : Dolicholagus, Iunclassified_Dolicholagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dolicholagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639636;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dolicholagus";
}
