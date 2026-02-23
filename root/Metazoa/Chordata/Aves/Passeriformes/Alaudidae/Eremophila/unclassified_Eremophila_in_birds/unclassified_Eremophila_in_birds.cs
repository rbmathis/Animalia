using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Eremophila;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Eremophila.unclassified_Eremophila_in_birds;

/// <summary>
/// Abstract class for unclassified Eremophila (in: birds) (no rank).
/// NCBI TaxId: 2677327
/// </summary>
public abstract class unclassified_Eremophila_in_birds : Eremophila, Iunclassified_Eremophila_in_birds
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eremophila (in: birds)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677327;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eremophila_in_birds";
}
