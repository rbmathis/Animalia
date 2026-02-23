namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felidae_incertae_sedis.Smilodon;

/// <summary>
/// Species: Smilodon fatalis
/// NCBI TaxId: 13266
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Smilodon_fatalis : Smilodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Smilodon fatalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Smilodon_fatalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 13266;
}
