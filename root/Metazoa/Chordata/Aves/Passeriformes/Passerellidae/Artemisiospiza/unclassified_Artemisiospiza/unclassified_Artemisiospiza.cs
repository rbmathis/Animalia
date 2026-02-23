using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Artemisiospiza;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Artemisiospiza.unclassified_Artemisiospiza;

/// <summary>
/// Abstract class for unclassified Artemisiospiza (no rank).
/// NCBI TaxId: 2878746
/// </summary>
public abstract class unclassified_Artemisiospiza : Artemisiospiza, Iunclassified_Artemisiospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Artemisiospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878746;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Artemisiospiza";
}
