namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Patagona;

/// <summary>
/// Species: Patagona gigas
/// NCBI TaxId: 304667
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Patagona_gigas : Patagona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Patagona gigas";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Patagona_gigas";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 304667;
}
