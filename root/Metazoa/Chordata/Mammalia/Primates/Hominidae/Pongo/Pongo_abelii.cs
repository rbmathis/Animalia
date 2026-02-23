namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Pongo;

/// <summary>
/// Species: Pongo abelii
/// NCBI TaxId: 9601
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pongo_abelii : Pongo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pongo abelii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pongo_abelii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9601;
}
