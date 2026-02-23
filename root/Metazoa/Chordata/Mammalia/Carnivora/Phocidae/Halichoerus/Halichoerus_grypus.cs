namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Halichoerus;

/// <summary>
/// Species: Halichoerus grypus
/// NCBI TaxId: 9711
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Halichoerus_grypus : Halichoerus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Halichoerus grypus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Halichoerus_grypus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9711;
}
