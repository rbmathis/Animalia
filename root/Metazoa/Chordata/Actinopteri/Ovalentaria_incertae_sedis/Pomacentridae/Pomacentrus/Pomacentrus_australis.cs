namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Pomacentrus;

/// <summary>
/// Species: Pomacentrus australis
/// NCBI TaxId: 229131
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pomacentrus_australis : Pomacentrus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pomacentrus australis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pomacentrus_australis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 229131;
}
