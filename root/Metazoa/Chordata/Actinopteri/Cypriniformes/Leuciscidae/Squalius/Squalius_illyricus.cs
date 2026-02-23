namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Squalius;

/// <summary>
/// Species: Squalius illyricus
/// NCBI TaxId: 108512
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalius_illyricus : Squalius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalius illyricus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalius_illyricus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 108512;
}
