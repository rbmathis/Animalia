namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Pelophryne;

/// <summary>
/// Species: Pelophryne guentheri
/// NCBI TaxId: 1933915
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelophryne_guentheri : Pelophryne
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelophryne guentheri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelophryne_guentheri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1933915;
}
