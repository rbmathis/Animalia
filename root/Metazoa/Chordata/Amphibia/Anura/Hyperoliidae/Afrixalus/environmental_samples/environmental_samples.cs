using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Afrixalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Afrixalus.environmental_samples;

/// <summary>
/// Abstract class for environmental samples (no rank).
/// NCBI TaxId: 1109612
/// </summary>
public abstract class environmental_samples : Afrixalus, Ienvironmental_samples
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "environmental samples";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1109612;

    /// <inheritdoc />
    public virtual string Description => "Taxon: environmental_samples";
}
