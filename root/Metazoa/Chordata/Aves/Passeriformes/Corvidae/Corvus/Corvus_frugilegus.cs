namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Corvus;

/// <summary>
/// Species: Corvus frugilegus
/// NCBI TaxId: 75140
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Corvus_frugilegus : Corvus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Corvus frugilegus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Corvus_frugilegus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 75140;
}
