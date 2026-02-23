namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Amazona;

/// <summary>
/// Species: Amazona farinosa
/// NCBI TaxId: 151760
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amazona_farinosa : Amazona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amazona farinosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amazona_farinosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 151760;
}
