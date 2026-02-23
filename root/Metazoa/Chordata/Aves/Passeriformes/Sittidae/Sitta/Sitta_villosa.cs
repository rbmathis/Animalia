namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sittidae.Sitta;

/// <summary>
/// Species: Sitta villosa
/// NCBI TaxId: 50257
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sitta_villosa : Sitta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sitta villosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sitta_villosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 50257;
}
