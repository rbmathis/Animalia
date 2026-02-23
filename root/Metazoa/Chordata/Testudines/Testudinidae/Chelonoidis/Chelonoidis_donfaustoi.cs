namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Chelonoidis;

/// <summary>
/// Species: Chelonoidis donfaustoi
/// NCBI TaxId: 1743023
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelonoidis_donfaustoi : Chelonoidis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelonoidis donfaustoi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelonoidis_donfaustoi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1743023;
}
