using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Leucicorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Leucicorus.unclassified_Leucicorus;

/// <summary>
/// Abstract class for unclassified Leucicorus (no rank).
/// NCBI TaxId: 3448519
/// </summary>
public abstract class unclassified_Leucicorus : Leucicorus, Iunclassified_Leucicorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leucicorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3448519;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leucicorus";
}
