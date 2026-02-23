namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Triclaria;

/// <summary>
/// Species: Triclaria malachitacea
/// NCBI TaxId: 303326
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Triclaria_malachitacea : Triclaria
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Triclaria malachitacea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Triclaria_malachitacea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 303326;
}
