namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Prionailurus;

/// <summary>
/// Species: Prionailurus rubiginosus
/// NCBI TaxId: 61387
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Prionailurus_rubiginosus : Prionailurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Prionailurus rubiginosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Prionailurus_rubiginosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61387;
}
