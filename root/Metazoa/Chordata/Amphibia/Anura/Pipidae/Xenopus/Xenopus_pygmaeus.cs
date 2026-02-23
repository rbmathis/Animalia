namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Xenopus;

/// <summary>
/// Species: Xenopus pygmaeus
/// NCBI TaxId: 288517
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenopus_pygmaeus : Xenopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenopus pygmaeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenopus_pygmaeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 288517;
}
