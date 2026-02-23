namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Nyctimantis;

/// <summary>
/// Species: Nyctimantis bokermanni
/// NCBI TaxId: 2728944
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctimantis_bokermanni : Nyctimantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctimantis bokermanni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctimantis_bokermanni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2728944;
}
