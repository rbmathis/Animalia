using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Hollandichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Hollandichthys.unclassified_Hollandichthys;

/// <summary>
/// Abstract class for unclassified Hollandichthys (no rank).
/// NCBI TaxId: 2644536
/// </summary>
public abstract class unclassified_Hollandichthys : Hollandichthys, Iunclassified_Hollandichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hollandichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644536;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hollandichthys";
}
