namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacara;

/// <summary>
/// Species: Psittacara chloropterus
/// NCBI TaxId: 867386
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psittacara_chloropterus : Psittacara
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psittacara chloropterus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psittacara_chloropterus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 867386;
}
