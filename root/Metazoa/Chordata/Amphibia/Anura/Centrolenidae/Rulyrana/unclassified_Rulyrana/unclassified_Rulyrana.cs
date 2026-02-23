using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Rulyrana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Rulyrana.unclassified_Rulyrana;

/// <summary>
/// Abstract class for unclassified Rulyrana (no rank).
/// NCBI TaxId: 2644693
/// </summary>
public abstract class unclassified_Rulyrana : Rulyrana, Iunclassified_Rulyrana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rulyrana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644693;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rulyrana";
}
