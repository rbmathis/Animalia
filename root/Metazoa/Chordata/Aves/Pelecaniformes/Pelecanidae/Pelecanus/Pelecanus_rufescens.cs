namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Pelecanidae.Pelecanus;

/// <summary>
/// Species: Pelecanus rufescens
/// NCBI TaxId: 1243782
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelecanus_rufescens : Pelecanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelecanus rufescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelecanus_rufescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1243782;
}
