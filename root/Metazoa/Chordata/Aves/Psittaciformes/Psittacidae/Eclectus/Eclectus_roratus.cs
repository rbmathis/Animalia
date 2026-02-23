namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Eclectus;

/// <summary>
/// Species: Eclectus roratus
/// NCBI TaxId: 176024
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eclectus_roratus : Eclectus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eclectus roratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eclectus_roratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 176024;
}
