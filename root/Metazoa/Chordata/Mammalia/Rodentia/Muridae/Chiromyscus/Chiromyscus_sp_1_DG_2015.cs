namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Chiromyscus;

/// <summary>
/// Species: Chiromyscus sp. 1 DG-2015
/// NCBI TaxId: 1772166
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chiromyscus_sp_1_DG_2015 : Chiromyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chiromyscus sp. 1 DG-2015";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chiromyscus_sp_1_DG_2015";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1772166;
}
