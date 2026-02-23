namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Pipa;

/// <summary>
/// Species: Pipa parva
/// NCBI TaxId: 247091
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pipa_parva : Pipa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pipa parva";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pipa_parva";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 247091;
}
