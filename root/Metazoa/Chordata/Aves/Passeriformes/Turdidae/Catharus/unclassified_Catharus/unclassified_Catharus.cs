using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Catharus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Catharus.unclassified_Catharus;

/// <summary>
/// Abstract class for unclassified Catharus (no rank).
/// NCBI TaxId: 2624587
/// </summary>
public abstract class unclassified_Catharus : Catharus, Iunclassified_Catharus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Catharus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624587;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Catharus";
}
