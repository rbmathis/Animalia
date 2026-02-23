namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Nyctimene;

/// <summary>
/// Species: Nyctimene vizcaccia
/// NCBI TaxId: 170211
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctimene_vizcaccia : Nyctimene
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctimene vizcaccia";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctimene_vizcaccia";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 170211;
}
