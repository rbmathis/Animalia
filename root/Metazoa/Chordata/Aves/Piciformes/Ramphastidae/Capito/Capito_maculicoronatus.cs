namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae.Capito;

/// <summary>
/// Species: Capito maculicoronatus
/// NCBI TaxId: 322577
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Capito_maculicoronatus : Capito
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Capito maculicoronatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Capito_maculicoronatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 322577;
}
