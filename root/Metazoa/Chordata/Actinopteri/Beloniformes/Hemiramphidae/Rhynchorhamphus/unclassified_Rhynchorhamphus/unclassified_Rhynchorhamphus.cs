using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Rhynchorhamphus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Rhynchorhamphus.unclassified_Rhynchorhamphus;

/// <summary>
/// Abstract class for unclassified Rhynchorhamphus (no rank).
/// NCBI TaxId: 2691023
/// </summary>
public abstract class unclassified_Rhynchorhamphus : Rhynchorhamphus, Iunclassified_Rhynchorhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhynchorhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2691023;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhynchorhamphus";
}
