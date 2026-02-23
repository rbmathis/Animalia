namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Dryophytes;

/// <summary>
/// Species: Dryophytes japonicus
/// NCBI TaxId: 109175
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dryophytes_japonicus : Dryophytes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dryophytes japonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dryophytes_japonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 109175;
}
