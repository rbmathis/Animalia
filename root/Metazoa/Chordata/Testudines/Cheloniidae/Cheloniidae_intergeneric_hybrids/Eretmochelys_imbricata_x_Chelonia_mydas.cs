namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Cheloniidae_intergeneric_hybrids;

/// <summary>
/// Species: Eretmochelys imbricata x Chelonia mydas
/// NCBI TaxId: 202019
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eretmochelys_imbricata_x_Chelonia_mydas : Cheloniidae_intergeneric_hybrids
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eretmochelys imbricata x Chelonia mydas";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eretmochelys_imbricata_x_Chelonia_mydas";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 202019;
}
