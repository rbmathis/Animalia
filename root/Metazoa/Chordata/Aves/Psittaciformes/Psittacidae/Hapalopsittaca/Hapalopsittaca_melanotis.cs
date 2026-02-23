namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Hapalopsittaca;

/// <summary>
/// Species: Hapalopsittaca melanotis
/// NCBI TaxId: 867392
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hapalopsittaca_melanotis : Hapalopsittaca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hapalopsittaca melanotis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hapalopsittaca_melanotis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 867392;
}
