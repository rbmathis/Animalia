namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Squalius;

/// <summary>
/// Species: Squalius squalus x Squalius lucumonis
/// NCBI TaxId: 1482343
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalius_squalus_x_Squalius_lucumonis : Squalius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalius squalus x Squalius lucumonis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalius_squalus_x_Squalius_lucumonis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1482343;
}
