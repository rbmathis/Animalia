namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Zapus;

/// <summary>
/// Species: Zapus princeps
/// NCBI TaxId: 162168
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Zapus_princeps : Zapus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Zapus princeps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Zapus_princeps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 162168;
}
