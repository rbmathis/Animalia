namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Xerus;

/// <summary>
/// Species: Xerus princeps
/// NCBI TaxId: 327506
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xerus_princeps : Xerus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xerus princeps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xerus_princeps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 327506;
}
