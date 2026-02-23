namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Lutra;

/// <summary>
/// Species: Lutra environmental sample
/// NCBI TaxId: 1002247
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lutra_environmental_sample : Lutra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lutra environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lutra_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1002247;
}
