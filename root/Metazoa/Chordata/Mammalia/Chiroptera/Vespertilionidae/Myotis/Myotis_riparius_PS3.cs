namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis riparius PS3
/// NCBI TaxId: 409039
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_riparius_PS3 : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis riparius PS3";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_riparius_PS3";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 409039;
}
