namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Lagothrix;

/// <summary>
/// Species: Lagothrix poeppigii
/// NCBI TaxId: 767356
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lagothrix_poeppigii : Lagothrix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lagothrix poeppigii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lagothrix_poeppigii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 767356;
}
