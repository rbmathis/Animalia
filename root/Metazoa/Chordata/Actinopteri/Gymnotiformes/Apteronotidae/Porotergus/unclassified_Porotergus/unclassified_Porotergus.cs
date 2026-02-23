using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Porotergus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Porotergus.unclassified_Porotergus;

/// <summary>
/// Abstract class for unclassified Porotergus (no rank).
/// NCBI TaxId: 2634119
/// </summary>
public abstract class unclassified_Porotergus : Porotergus, Iunclassified_Porotergus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Porotergus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634119;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Porotergus";
}
