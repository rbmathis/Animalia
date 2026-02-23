namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Mustela;

/// <summary>
/// Species: Mustela sibirica
/// NCBI TaxId: 36240
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mustela_sibirica : Mustela
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mustela sibirica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mustela_sibirica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 36240;
}
