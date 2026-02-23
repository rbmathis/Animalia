namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anas;

/// <summary>
/// Species: Anas melleri
/// NCBI TaxId: 75852
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anas_melleri : Anas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anas melleri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anas_melleri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 75852;
}
