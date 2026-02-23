namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Gallinago;

/// <summary>
/// Species: Gallinago nigripennis
/// NCBI TaxId: 586766
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gallinago_nigripennis : Gallinago
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gallinago nigripennis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gallinago_nigripennis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 586766;
}
