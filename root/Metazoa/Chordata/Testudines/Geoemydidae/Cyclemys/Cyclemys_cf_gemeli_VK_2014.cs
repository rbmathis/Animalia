namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cyclemys;

/// <summary>
/// Species: Cyclemys cf. gemeli VK-2014
/// NCBI TaxId: 1585643
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyclemys_cf_gemeli_VK_2014 : Cyclemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyclemys cf. gemeli VK-2014";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyclemys_cf_gemeli_VK_2014";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1585643;
}
