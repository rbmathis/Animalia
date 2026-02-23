namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Squalius;

/// <summary>
/// Species: Squalius malacitanus
/// NCBI TaxId: 882991
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalius_malacitanus : Squalius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalius malacitanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalius_malacitanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 882991;
}
