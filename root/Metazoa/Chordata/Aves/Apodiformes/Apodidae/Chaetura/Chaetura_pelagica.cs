namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Chaetura;

/// <summary>
/// Species: Chaetura pelagica
/// NCBI TaxId: 8897
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chaetura_pelagica : Chaetura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chaetura pelagica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chaetura_pelagica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8897;
}
