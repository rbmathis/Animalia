namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Xenus;

/// <summary>
/// Species: Xenus cinereus
/// NCBI TaxId: 171277
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenus_cinereus : Xenus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenus cinereus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenus_cinereus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 171277;
}
