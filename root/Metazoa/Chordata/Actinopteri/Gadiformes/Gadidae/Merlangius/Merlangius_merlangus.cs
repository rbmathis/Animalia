namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Merlangius;

/// <summary>
/// Species: Merlangius merlangus
/// NCBI TaxId: 8058
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Merlangius_merlangus : Merlangius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Merlangius merlangus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Merlangius_merlangus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8058;
}
