namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hylobatidae.Hylobates;

/// <summary>
/// Species: Hylobates muelleri
/// NCBI TaxId: 9588
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylobates_muelleri : Hylobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylobates muelleri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylobates_muelleri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9588;
}
