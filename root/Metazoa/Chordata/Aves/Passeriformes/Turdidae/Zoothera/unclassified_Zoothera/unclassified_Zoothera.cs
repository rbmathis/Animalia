using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Zoothera;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Zoothera.unclassified_Zoothera;

/// <summary>
/// Abstract class for unclassified Zoothera (no rank).
/// NCBI TaxId: 2642695
/// </summary>
public abstract class unclassified_Zoothera : Zoothera, Iunclassified_Zoothera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zoothera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642695;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zoothera";
}
