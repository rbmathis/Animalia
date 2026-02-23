namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Peliperdix;

/// <summary>
/// Species: Peliperdix albogularis
/// NCBI TaxId: 3150881
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Peliperdix_albogularis : Peliperdix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Peliperdix albogularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Peliperdix_albogularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150881;
}
