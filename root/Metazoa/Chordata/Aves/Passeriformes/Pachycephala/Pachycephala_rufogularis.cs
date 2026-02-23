namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pachycephala;

/// <summary>
/// Species: Pachycephala rufogularis
/// NCBI TaxId: 449357
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachycephala_rufogularis : Pachycephala
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachycephala rufogularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachycephala_rufogularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 449357;
}
