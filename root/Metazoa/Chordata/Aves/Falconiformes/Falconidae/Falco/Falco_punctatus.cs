namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Falco;

/// <summary>
/// Species: Falco punctatus
/// NCBI TaxId: 148596
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Falco_punctatus : Falco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Falco punctatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Falco_punctatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 148596;
}
