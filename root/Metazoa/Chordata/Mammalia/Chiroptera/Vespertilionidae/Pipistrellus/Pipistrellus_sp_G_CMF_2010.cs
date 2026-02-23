namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Pipistrellus;

/// <summary>
/// Species: Pipistrellus sp. G CMF-2010
/// NCBI TaxId: 867880
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pipistrellus_sp_G_CMF_2010 : Pipistrellus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pipistrellus sp. G CMF-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pipistrellus_sp_G_CMF_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 867880;
}
