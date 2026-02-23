namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Contopus;

/// <summary>
/// Species: Contopus latirostris
/// NCBI TaxId: 200366
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Contopus_latirostris : Contopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Contopus latirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Contopus_latirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 200366;
}
