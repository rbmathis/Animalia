namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Mustela;

/// <summary>
/// Species: Mustela erminea
/// NCBI TaxId: 36723
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mustela_erminea : Mustela
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mustela erminea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mustela_erminea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 36723;
}
