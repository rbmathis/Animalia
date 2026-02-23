namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Mustela;

/// <summary>
/// Species: Mustela altaica
/// NCBI TaxId: 92062
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mustela_altaica : Mustela
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mustela altaica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mustela_altaica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 92062;
}
