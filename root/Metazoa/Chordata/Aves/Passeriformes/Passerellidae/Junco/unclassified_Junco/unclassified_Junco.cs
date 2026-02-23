using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Junco;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Junco.unclassified_Junco;

/// <summary>
/// Abstract class for unclassified Junco (no rank).
/// NCBI TaxId: 2789765
/// </summary>
public abstract class unclassified_Junco : Junco, Iunclassified_Junco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Junco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2789765;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Junco";
}
