namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sittidae.Sitta;

/// <summary>
/// Species: Sitta carolinensis
/// NCBI TaxId: 50250
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sitta_carolinensis : Sitta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sitta carolinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sitta_carolinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 50250;
}
