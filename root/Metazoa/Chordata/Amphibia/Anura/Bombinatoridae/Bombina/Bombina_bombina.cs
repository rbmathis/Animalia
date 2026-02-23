namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bombinatoridae.Bombina;

/// <summary>
/// Species: Bombina bombina
/// NCBI TaxId: 8345
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bombina_bombina : Bombina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bombina bombina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bombina_bombina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8345;
}
