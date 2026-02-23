namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Notochelys;

/// <summary>
/// Species: Notochelys platynota
/// NCBI TaxId: 204958
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Notochelys_platynota : Notochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Notochelys platynota";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Notochelys_platynota";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 204958;
}
