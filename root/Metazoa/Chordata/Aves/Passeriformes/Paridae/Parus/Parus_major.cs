namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Parus;

/// <summary>
/// Species: Parus major
/// NCBI TaxId: 9157
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Parus_major : Parus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Parus major";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Parus_major";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9157;
}
