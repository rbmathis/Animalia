using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Parmaturus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Parmaturus.unclassified_Parmaturus;

/// <summary>
/// Abstract class for unclassified Parmaturus (no rank).
/// NCBI TaxId: 2639935
/// </summary>
public abstract class unclassified_Parmaturus : Parmaturus, Iunclassified_Parmaturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parmaturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639935;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parmaturus";
}
