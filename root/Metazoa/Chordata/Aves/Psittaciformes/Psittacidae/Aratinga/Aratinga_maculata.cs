namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Aratinga;

/// <summary>
/// Species: Aratinga maculata
/// NCBI TaxId: 1230190
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aratinga_maculata : Aratinga
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aratinga maculata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aratinga_maculata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1230190;
}
