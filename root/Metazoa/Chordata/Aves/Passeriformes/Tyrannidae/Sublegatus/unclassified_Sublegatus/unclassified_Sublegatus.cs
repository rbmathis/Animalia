using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Sublegatus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Sublegatus.unclassified_Sublegatus;

/// <summary>
/// Abstract class for unclassified Sublegatus (no rank).
/// NCBI TaxId: 2856183
/// </summary>
public abstract class unclassified_Sublegatus : Sublegatus, Iunclassified_Sublegatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sublegatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2856183;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sublegatus";
}
