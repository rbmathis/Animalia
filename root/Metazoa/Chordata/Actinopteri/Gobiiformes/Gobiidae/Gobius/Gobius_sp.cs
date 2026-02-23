namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobius;

/// <summary>
/// Species: Gobius sp.
/// NCBI TaxId: 45205
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gobius_sp : Gobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gobius sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gobius_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 45205;
}
