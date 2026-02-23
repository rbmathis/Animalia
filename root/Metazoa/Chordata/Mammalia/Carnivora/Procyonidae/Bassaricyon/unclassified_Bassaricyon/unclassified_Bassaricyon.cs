using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Bassaricyon;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Bassaricyon.unclassified_Bassaricyon;

/// <summary>
/// Abstract class for unclassified Bassaricyon (no rank).
/// NCBI TaxId: 2639555
/// </summary>
public abstract class unclassified_Bassaricyon : Bassaricyon, Iunclassified_Bassaricyon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bassaricyon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639555;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bassaricyon";
}
