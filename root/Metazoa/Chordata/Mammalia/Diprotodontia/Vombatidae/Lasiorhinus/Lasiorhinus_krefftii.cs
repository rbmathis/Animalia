namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Vombatidae.Lasiorhinus;

/// <summary>
/// Species: Lasiorhinus krefftii
/// NCBI TaxId: 30667
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lasiorhinus_krefftii : Lasiorhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lasiorhinus krefftii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lasiorhinus_krefftii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30667;
}
