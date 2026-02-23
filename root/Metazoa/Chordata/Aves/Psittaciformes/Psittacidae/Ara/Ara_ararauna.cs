namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Ara;

/// <summary>
/// Species: Ara ararauna
/// NCBI TaxId: 9226
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ara_ararauna : Ara
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ara ararauna";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ara_ararauna";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9226;
}
