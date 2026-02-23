namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Acanthochelys;

/// <summary>
/// Species: Acanthochelys macrocephala
/// NCBI TaxId: 440077
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acanthochelys_macrocephala : Acanthochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acanthochelys macrocephala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acanthochelys_macrocephala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 440077;
}
