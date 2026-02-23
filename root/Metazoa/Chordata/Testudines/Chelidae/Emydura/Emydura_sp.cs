namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Emydura;

/// <summary>
/// Species: Emydura sp.
/// NCBI TaxId: 2060765
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Emydura_sp : Emydura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Emydura sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Emydura_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2060765;
}
