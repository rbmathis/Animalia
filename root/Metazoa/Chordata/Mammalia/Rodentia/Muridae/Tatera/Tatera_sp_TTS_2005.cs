namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tatera;

/// <summary>
/// Species: Tatera sp. TTS-2005
/// NCBI TaxId: 347532
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tatera_sp_TTS_2005 : Tatera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tatera sp. TTS-2005";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tatera_sp_TTS_2005";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 347532;
}
