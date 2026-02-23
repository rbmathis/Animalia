namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Eugnathogobius;

/// <summary>
/// Species: Eugnathogobius sp.
/// NCBI TaxId: 3041905
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eugnathogobius_sp : Eugnathogobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eugnathogobius sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eugnathogobius_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3041905;
}
