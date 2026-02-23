namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Asio;

/// <summary>
/// Species: Asio otus
/// NCBI TaxId: 111810
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Asio_otus : Asio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Asio otus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Asio_otus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 111810;
}
