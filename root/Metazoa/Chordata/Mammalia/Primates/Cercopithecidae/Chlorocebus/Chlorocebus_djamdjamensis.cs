namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Chlorocebus;

/// <summary>
/// Species: Chlorocebus djamdjamensis
/// NCBI TaxId: 1284215
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chlorocebus_djamdjamensis : Chlorocebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chlorocebus djamdjamensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chlorocebus_djamdjamensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1284215;
}
