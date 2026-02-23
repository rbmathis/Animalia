namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Ophichthus;

/// <summary>
/// Species: Ophichthus olivaceus
/// NCBI TaxId: 2725125
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ophichthus_olivaceus : Ophichthus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ophichthus olivaceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ophichthus_olivaceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2725125;
}
