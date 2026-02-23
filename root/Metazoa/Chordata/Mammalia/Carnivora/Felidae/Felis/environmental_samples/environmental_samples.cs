using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felis.environmental_samples;

/// <summary>
/// Abstract class for environmental samples (no rank).
/// NCBI TaxId: 2665946
/// </summary>
public abstract class environmental_samples : Felis, Ienvironmental_samples
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "environmental samples";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2665946;

    /// <inheritdoc />
    public virtual string Description => "Taxon: environmental_samples";
}
