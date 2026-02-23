namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felinae_intergeneric_hybrids;

/// <summary>
/// Species: Felis catus x Leptailurus serval
/// NCBI TaxId: 3416723
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Felis_catus_x_Leptailurus_serval : Felinae_intergeneric_hybrids
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Felis catus x Leptailurus serval";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Felis_catus_x_Leptailurus_serval";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3416723;
}
