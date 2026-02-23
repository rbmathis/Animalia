namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Parus;

/// <summary>
/// Species: Parus minor
/// NCBI TaxId: 213890
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Parus_minor : Parus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Parus minor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Parus_minor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 213890;
}
