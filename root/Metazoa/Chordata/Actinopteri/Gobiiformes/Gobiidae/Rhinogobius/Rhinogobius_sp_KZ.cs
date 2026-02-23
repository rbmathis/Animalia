namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Rhinogobius;

/// <summary>
/// Species: Rhinogobius sp. KZ
/// NCBI TaxId: 1544533
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinogobius_sp_KZ : Rhinogobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinogobius sp. KZ";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinogobius_sp_KZ";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1544533;
}
