namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Streptopelia;

/// <summary>
/// Species: Streptopelia lugens
/// NCBI TaxId: 1856040
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Streptopelia_lugens : Streptopelia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Streptopelia lugens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Streptopelia_lugens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1856040;
}
