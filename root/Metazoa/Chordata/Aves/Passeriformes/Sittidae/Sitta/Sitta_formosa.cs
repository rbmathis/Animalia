namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sittidae.Sitta;

/// <summary>
/// Species: Sitta formosa
/// NCBI TaxId: 1464051
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sitta_formosa : Sitta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sitta formosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sitta_formosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1464051;
}
