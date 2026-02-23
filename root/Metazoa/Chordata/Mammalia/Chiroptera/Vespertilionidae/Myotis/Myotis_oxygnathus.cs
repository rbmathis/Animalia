namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis oxygnathus
/// NCBI TaxId: 412095
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_oxygnathus : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis oxygnathus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_oxygnathus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 412095;
}
