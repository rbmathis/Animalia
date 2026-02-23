namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Trichoglossus;

/// <summary>
/// Species: Trichoglossus moluccanus
/// NCBI TaxId: 1549204
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trichoglossus_moluccanus : Trichoglossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trichoglossus moluccanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trichoglossus_moluccanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1549204;
}
