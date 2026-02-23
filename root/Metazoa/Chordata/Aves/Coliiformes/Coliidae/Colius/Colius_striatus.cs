namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coliiformes.Coliidae.Colius;

/// <summary>
/// Species: Colius striatus
/// NCBI TaxId: 57412
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Colius_striatus : Colius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Colius striatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Colius_striatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 57412;
}
