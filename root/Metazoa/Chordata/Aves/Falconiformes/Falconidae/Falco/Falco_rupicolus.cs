namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Falco;

/// <summary>
/// Species: Falco rupicolus
/// NCBI TaxId: 1562128
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Falco_rupicolus : Falco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Falco rupicolus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Falco_rupicolus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1562128;
}
