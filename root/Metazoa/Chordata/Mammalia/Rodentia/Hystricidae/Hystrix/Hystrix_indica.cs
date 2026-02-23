namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hystricidae.Hystrix;

/// <summary>
/// Species: Hystrix indica
/// NCBI TaxId: 192883
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hystrix_indica : Hystrix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hystrix indica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hystrix_indica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 192883;
}
