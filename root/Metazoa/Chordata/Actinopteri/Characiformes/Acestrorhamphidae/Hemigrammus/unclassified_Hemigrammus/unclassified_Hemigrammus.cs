using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Hemigrammus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Hemigrammus.unclassified_Hemigrammus;

/// <summary>
/// Abstract class for unclassified Hemigrammus (no rank).
/// NCBI TaxId: 2984183
/// </summary>
public abstract class unclassified_Hemigrammus : Hemigrammus, Iunclassified_Hemigrammus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemigrammus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2984183;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemigrammus";
}
