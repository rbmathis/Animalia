namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacara;

/// <summary>
/// Species: Psittacara strenuus
/// NCBI TaxId: 2259669
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psittacara_strenuus : Psittacara
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psittacara strenuus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psittacara_strenuus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2259669;
}
