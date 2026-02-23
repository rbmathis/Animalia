namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacara;

/// <summary>
/// Species: Psittacara erythrogenys
/// NCBI TaxId: 12946
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psittacara_erythrogenys : Psittacara
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psittacara erythrogenys";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psittacara_erythrogenys";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 12946;
}
