namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Struthionidae.Struthio;

/// <summary>
/// Species: Struthio camelus
/// NCBI TaxId: 8801
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Struthio_camelus : Struthio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Struthio camelus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Struthio_camelus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8801;
}
