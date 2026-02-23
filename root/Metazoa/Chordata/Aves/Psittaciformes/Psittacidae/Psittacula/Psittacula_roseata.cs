namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacula;

/// <summary>
/// Species: Psittacula roseata
/// NCBI TaxId: 232641
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psittacula_roseata : Psittacula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psittacula roseata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psittacula_roseata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 232641;
}
