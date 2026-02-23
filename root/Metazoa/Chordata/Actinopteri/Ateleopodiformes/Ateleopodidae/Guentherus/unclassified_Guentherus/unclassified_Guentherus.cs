using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ateleopodiformes.Ateleopodidae.Guentherus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ateleopodiformes.Ateleopodidae.Guentherus.unclassified_Guentherus;

/// <summary>
/// Abstract class for unclassified Guentherus (no rank).
/// NCBI TaxId: 2643004
/// </summary>
public abstract class unclassified_Guentherus : Guentherus, Iunclassified_Guentherus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Guentherus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643004;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Guentherus";
}
