namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alytidae.Alytes;

/// <summary>
/// Species: Alytes muletensis
/// NCBI TaxId: 97955
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alytes_muletensis : Alytes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alytes muletensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alytes_muletensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 97955;
}
