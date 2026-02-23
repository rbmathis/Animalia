namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacula;

/// <summary>
/// Species: Psittacula alexandri
/// NCBI TaxId: 232635
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psittacula_alexandri : Psittacula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psittacula alexandri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psittacula_alexandri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 232635;
}
