using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Sousa;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Sousa.unclassified_Sousa;

/// <summary>
/// Abstract class for unclassified Sousa (no rank).
/// NCBI TaxId: 2622018
/// </summary>
public abstract class unclassified_Sousa : Sousa, Iunclassified_Sousa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sousa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622018;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sousa";
}
