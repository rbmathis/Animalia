namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Mustela;

/// <summary>
/// Species: Mustela putorius x Mustela putorius furo
/// NCBI TaxId: 1353796
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mustela_putorius_x_Mustela_putorius_furo : Mustela
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mustela putorius x Mustela putorius furo";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mustela_putorius_x_Mustela_putorius_furo";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1353796;
}
