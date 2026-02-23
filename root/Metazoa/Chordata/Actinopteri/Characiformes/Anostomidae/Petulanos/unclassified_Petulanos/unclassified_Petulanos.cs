using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Petulanos;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Petulanos.unclassified_Petulanos;

/// <summary>
/// Abstract class for unclassified Petulanos (no rank).
/// NCBI TaxId: 3101886
/// </summary>
public abstract class unclassified_Petulanos : Petulanos, Iunclassified_Petulanos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Petulanos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101886;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Petulanos";
}
