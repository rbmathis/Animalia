using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Blarina;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Blarina.unclassified_Blarina;

/// <summary>
/// Abstract class for unclassified Blarina (no rank).
/// NCBI TaxId: 2646543
/// </summary>
public abstract class unclassified_Blarina : Blarina, Iunclassified_Blarina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Blarina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646543;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Blarina";
}
