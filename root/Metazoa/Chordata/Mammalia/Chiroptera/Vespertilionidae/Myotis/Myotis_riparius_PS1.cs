namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis riparius PS1
/// NCBI TaxId: 409037
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_riparius_PS1 : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis riparius PS1";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_riparius_PS1";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 409037;
}
