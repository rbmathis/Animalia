namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Aethia;

/// <summary>
/// Species: Aethia psittacula
/// NCBI TaxId: 28699
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aethia_psittacula : Aethia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aethia psittacula";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aethia_psittacula";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 28699;
}
