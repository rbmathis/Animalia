namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Macropus;

/// <summary>
/// Species: Macropus fuliginosus
/// NCBI TaxId: 9316
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macropus_fuliginosus : Macropus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macropus fuliginosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macropus_fuliginosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9316;
}
