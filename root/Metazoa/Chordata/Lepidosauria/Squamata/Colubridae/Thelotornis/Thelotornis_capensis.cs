namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Thelotornis;

/// <summary>
/// Species: Thelotornis capensis
/// NCBI TaxId: 186609
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thelotornis_capensis : Thelotornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thelotornis capensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thelotornis_capensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 186609;
}
