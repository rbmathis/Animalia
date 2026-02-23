namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Pseudemydura;

/// <summary>
/// Species: Pseudemydura umbrina
/// NCBI TaxId: 44510
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudemydura_umbrina : Pseudemydura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudemydura umbrina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudemydura_umbrina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 44510;
}
