namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Chlorocebus;

/// <summary>
/// Species: Chlorocebus tantalus
/// NCBI TaxId: 60712
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chlorocebus_tantalus : Chlorocebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chlorocebus tantalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chlorocebus_tantalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 60712;
}
