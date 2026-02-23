namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Agkistrodon;

/// <summary>
/// Species: Agkistrodon sp.
/// NCBI TaxId: 3467895
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Agkistrodon_sp : Agkistrodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Agkistrodon sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Agkistrodon_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3467895;
}
