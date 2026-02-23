namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felis;

/// <summary>
/// Species: Felis margarita
/// NCBI TaxId: 61378
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Felis_margarita : Felis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Felis margarita";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Felis_margarita";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61378;
}
