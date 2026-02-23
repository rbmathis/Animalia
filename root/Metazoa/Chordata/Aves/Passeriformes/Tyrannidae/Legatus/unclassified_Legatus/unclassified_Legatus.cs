using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Legatus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Legatus.unclassified_Legatus;

/// <summary>
/// Abstract class for unclassified Legatus (no rank).
/// NCBI TaxId: 2797241
/// </summary>
public abstract class unclassified_Legatus : Legatus, Iunclassified_Legatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Legatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2797241;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Legatus";
}
