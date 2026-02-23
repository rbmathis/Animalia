using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Arctotherium;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Arctotherium.unclassified_Arctotherium;

/// <summary>
/// Abstract class for unclassified Arctotherium (no rank).
/// NCBI TaxId: 2640560
/// </summary>
public abstract class unclassified_Arctotherium : Arctotherium, Iunclassified_Arctotherium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Arctotherium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640560;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Arctotherium";
}
