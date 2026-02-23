using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombropidae.Scombrops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombropidae.Scombrops.unclassified_Scombrops;

/// <summary>
/// Abstract class for unclassified Scombrops (no rank).
/// NCBI TaxId: 2627958
/// </summary>
public abstract class unclassified_Scombrops : Scombrops, Iunclassified_Scombrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scombrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627958;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scombrops";
}
