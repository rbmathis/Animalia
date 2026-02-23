namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Eretmochelys;

/// <summary>
/// Species: Eretmochelys imbricata
/// NCBI TaxId: 27787
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eretmochelys_imbricata : Eretmochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eretmochelys imbricata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eretmochelys_imbricata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 27787;
}
