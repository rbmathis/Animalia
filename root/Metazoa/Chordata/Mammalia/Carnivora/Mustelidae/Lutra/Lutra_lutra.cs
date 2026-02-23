namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Lutra;

/// <summary>
/// Species: Lutra lutra
/// NCBI TaxId: 9657
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lutra_lutra : Lutra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lutra lutra";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lutra_lutra";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9657;
}
