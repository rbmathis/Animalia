using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Neoplecostomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Neoplecostomus.unclassified_Neoplecostomus;

/// <summary>
/// Abstract class for unclassified Neoplecostomus (no rank).
/// NCBI TaxId: 2642966
/// </summary>
public abstract class unclassified_Neoplecostomus : Neoplecostomus, Iunclassified_Neoplecostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neoplecostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642966;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neoplecostomus";
}
