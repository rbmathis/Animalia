namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Emydura;

/// <summary>
/// Species: Emydura macquarii
/// NCBI TaxId: 90392
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Emydura_macquarii : Emydura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Emydura macquarii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Emydura_macquarii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 90392;
}
