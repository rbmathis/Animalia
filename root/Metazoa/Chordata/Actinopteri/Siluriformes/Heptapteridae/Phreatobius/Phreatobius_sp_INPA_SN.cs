namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Phreatobius;

/// <summary>
/// Species: Phreatobius sp. INPA S/N
/// NCBI TaxId: 1281324
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phreatobius_sp_INPA_SN : Phreatobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phreatobius sp. INPA S/N";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phreatobius_sp_INPA_SN";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1281324;
}
