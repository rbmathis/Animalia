namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Echinosaura;

/// <summary>
/// Species: Echinosaura sp.
/// NCBI TaxId: 2805822
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Echinosaura_sp : Echinosaura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Echinosaura sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Echinosaura_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2805822;
}
