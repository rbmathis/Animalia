using AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae.Podocnemis;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae.Podocnemis.unclassified_Podocnemis;

/// <summary>
/// Abstract class for unclassified Podocnemis (no rank).
/// NCBI TaxId: 2637756
/// </summary>
public abstract class unclassified_Podocnemis : Podocnemis, Iunclassified_Podocnemis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Podocnemis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637756;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Podocnemis";
}
