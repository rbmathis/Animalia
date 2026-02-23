namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis riparius PS2
/// NCBI TaxId: 409038
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_riparius_PS2 : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis riparius PS2";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_riparius_PS2";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 409038;
}
