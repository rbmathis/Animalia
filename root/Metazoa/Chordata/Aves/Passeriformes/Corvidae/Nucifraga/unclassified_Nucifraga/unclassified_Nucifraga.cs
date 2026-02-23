using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Nucifraga;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Nucifraga.unclassified_Nucifraga;

/// <summary>
/// Abstract class for unclassified Nucifraga (no rank).
/// NCBI TaxId: 3467919
/// </summary>
public abstract class unclassified_Nucifraga : Nucifraga, Iunclassified_Nucifraga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nucifraga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3467919;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nucifraga";
}
