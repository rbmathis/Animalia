namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Penelope;

/// <summary>
/// Species: Penelope obscura
/// NCBI TaxId: 125071
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Penelope_obscura : Penelope
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Penelope obscura";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Penelope_obscura";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 125071;
}
