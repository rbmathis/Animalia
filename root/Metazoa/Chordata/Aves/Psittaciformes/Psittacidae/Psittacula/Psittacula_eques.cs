namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacula;

/// <summary>
/// Species: Psittacula eques
/// NCBI TaxId: 1560315
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psittacula_eques : Psittacula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psittacula eques";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psittacula_eques";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1560315;
}
