using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.unclassified_Scombriformes;

/// <summary>
/// Abstract class for unclassified Scombriformes (no rank).
/// NCBI TaxId: 1490090
/// </summary>
public abstract class unclassified_Scombriformes : Scombriformes, Iunclassified_Scombriformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scombriformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1490090;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scombriformes";
}
