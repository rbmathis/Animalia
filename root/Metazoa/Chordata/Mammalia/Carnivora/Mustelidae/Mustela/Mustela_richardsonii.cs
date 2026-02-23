namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Mustela;

/// <summary>
/// Species: Mustela richardsonii
/// NCBI TaxId: 2599797
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mustela_richardsonii : Mustela
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mustela richardsonii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mustela_richardsonii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2599797;
}
