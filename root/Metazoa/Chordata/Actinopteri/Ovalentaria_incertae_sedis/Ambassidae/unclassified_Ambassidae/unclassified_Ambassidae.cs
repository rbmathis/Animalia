using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae.unclassified_Ambassidae;

/// <summary>
/// Abstract class for unclassified Ambassidae (no rank).
/// NCBI TaxId: 3040159
/// </summary>
public abstract class unclassified_Ambassidae : Ambassidae, Iunclassified_Ambassidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ambassidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3040159;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ambassidae";
}
