using AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Sulidae.Morus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Sulidae.Morus.unclassified_Morus_in_birds;

/// <summary>
/// Abstract class for unclassified Morus (in: birds) (no rank).
/// NCBI TaxId: 2688708
/// </summary>
public abstract class unclassified_Morus_in_birds : Morus, Iunclassified_Morus_in_birds
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Morus (in: birds)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688708;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Morus_in_birds";
}
