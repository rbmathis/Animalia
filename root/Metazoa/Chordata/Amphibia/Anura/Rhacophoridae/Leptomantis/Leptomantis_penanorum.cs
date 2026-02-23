namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Leptomantis;

/// <summary>
/// Species: Leptomantis penanorum
/// NCBI TaxId: 3372046
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leptomantis_penanorum : Leptomantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leptomantis penanorum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leptomantis_penanorum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3372046;
}
