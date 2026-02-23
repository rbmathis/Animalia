namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Apodemus;

/// <summary>
/// Species: Apodemus sp. TTS-2004a
/// NCBI TaxId: 261752
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Apodemus_sp_TTS_2004a : Apodemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Apodemus sp. TTS-2004a";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Apodemus_sp_TTS_2004a";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 261752;
}
