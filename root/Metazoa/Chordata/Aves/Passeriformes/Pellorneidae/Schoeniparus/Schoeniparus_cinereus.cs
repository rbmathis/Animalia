namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pellorneidae.Schoeniparus;

/// <summary>
/// Species: Schoeniparus cinereus
/// NCBI TaxId: 3150510
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Schoeniparus_cinereus : Schoeniparus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Schoeniparus cinereus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Schoeniparus_cinereus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150510;
}
