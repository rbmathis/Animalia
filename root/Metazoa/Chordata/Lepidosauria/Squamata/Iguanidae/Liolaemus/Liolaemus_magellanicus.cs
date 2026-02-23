namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Liolaemus;

/// <summary>
/// Species: Liolaemus magellanicus
/// NCBI TaxId: 109422
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Liolaemus_magellanicus : Liolaemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Liolaemus magellanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Liolaemus_magellanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 109422;
}
