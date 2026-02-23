namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Colobus;

/// <summary>
/// Species: Colobus polykomos
/// NCBI TaxId: 9572
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Colobus_polykomos : Colobus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Colobus polykomos";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Colobus_polykomos";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9572;
}
