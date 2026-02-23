namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Zimmerius;

/// <summary>
/// Species: Zimmerius bolivianus
/// NCBI TaxId: 502660
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Zimmerius_bolivianus : Zimmerius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Zimmerius bolivianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Zimmerius_bolivianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 502660;
}
