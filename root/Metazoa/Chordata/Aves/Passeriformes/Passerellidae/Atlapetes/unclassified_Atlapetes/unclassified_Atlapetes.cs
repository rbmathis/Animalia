using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Atlapetes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Atlapetes.unclassified_Atlapetes;

/// <summary>
/// Abstract class for unclassified Atlapetes (no rank).
/// NCBI TaxId: 2928221
/// </summary>
public abstract class unclassified_Atlapetes : Atlapetes, Iunclassified_Atlapetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atlapetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2928221;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atlapetes";
}
