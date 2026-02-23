namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Loriculus;

/// <summary>
/// Species: Loriculus vernalis
/// NCBI TaxId: 1107400
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Loriculus_vernalis : Loriculus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Loriculus vernalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Loriculus_vernalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1107400;
}
