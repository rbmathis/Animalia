using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Stethojulis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Stethojulis.unclassified_Stethojulis;

/// <summary>
/// Abstract class for unclassified Stethojulis (no rank).
/// NCBI TaxId: 2989940
/// </summary>
public abstract class unclassified_Stethojulis : Stethojulis, Iunclassified_Stethojulis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stethojulis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2989940;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stethojulis";
}
