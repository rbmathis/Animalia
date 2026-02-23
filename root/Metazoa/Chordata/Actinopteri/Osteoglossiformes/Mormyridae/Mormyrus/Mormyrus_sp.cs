namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Mormyrus;

/// <summary>
/// Species: Mormyrus sp.
/// NCBI TaxId: 3037693
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mormyrus_sp : Mormyrus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mormyrus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mormyrus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3037693;
}
