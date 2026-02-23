namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Calonectris;

/// <summary>
/// Species: Calonectris borealis
/// NCBI TaxId: 1323832
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calonectris_borealis : Calonectris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calonectris borealis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calonectris_borealis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1323832;
}
