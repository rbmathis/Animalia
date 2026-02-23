namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Ara;

/// <summary>
/// Species: Ara chloropterus x Ara macao
/// NCBI TaxId: 861241
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ara_chloropterus_x_Ara_macao : Ara
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ara chloropterus x Ara macao";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ara_chloropterus_x_Ara_macao";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 861241;
}
