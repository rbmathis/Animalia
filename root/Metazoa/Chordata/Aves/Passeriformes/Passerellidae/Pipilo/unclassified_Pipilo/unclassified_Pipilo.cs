using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Pipilo;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Pipilo.unclassified_Pipilo;

/// <summary>
/// Abstract class for unclassified Pipilo (no rank).
/// NCBI TaxId: 3016530
/// </summary>
public abstract class unclassified_Pipilo : Pipilo, Iunclassified_Pipilo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pipilo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3016530;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pipilo";
}
