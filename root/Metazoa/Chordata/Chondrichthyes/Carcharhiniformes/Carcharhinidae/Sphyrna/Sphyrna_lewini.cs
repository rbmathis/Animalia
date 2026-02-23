namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Sphyrna;

/// <summary>
/// Species: Sphyrna lewini
/// NCBI TaxId: 7823
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphyrna_lewini : Sphyrna
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphyrna lewini";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphyrna_lewini";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7823;
}
