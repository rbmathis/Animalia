namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Dermatemydidae.Dermatemys;

/// <summary>
/// Species: Dermatemys mawii
/// NCBI TaxId: 55550
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dermatemys_mawii : Dermatemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dermatemys mawii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dermatemys_mawii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 55550;
}
