namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Nyctereutes;

/// <summary>
/// Species: Nyctereutes procyonoides
/// NCBI TaxId: 34880
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctereutes_procyonoides : Nyctereutes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctereutes procyonoides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctereutes_procyonoides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34880;
}
