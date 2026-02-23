namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Cacomantis;

/// <summary>
/// Species: Cacomantis leucolophus
/// NCBI TaxId: 3055983
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cacomantis_leucolophus : Cacomantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cacomantis leucolophus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cacomantis_leucolophus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3055983;
}
