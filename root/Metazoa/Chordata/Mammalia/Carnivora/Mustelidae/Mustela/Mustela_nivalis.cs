namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Mustela;

/// <summary>
/// Species: Mustela nivalis
/// NCBI TaxId: 36239
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mustela_nivalis : Mustela
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mustela nivalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mustela_nivalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 36239;
}
