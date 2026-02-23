namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cuora;

/// <summary>
/// Species: Cuora trifasciata
/// NCBI TaxId: 176192
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cuora_trifasciata : Cuora
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cuora trifasciata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cuora_trifasciata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 176192;
}
