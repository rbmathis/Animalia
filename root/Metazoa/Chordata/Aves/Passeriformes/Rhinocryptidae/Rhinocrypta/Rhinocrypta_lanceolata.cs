namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Rhinocrypta;

/// <summary>
/// Species: Rhinocrypta lanceolata
/// NCBI TaxId: 137539
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinocrypta_lanceolata : Rhinocrypta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinocrypta lanceolata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinocrypta_lanceolata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 137539;
}
