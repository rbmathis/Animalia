namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Chlorocebus;

/// <summary>
/// Species: Chlorocebus pygerythrus
/// NCBI TaxId: 60710
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chlorocebus_pygerythrus : Chlorocebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chlorocebus pygerythrus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chlorocebus_pygerythrus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 60710;
}
