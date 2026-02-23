namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Cardiocranius;

/// <summary>
/// Species: Cardiocranius paradoxus
/// NCBI TaxId: 1041411
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cardiocranius_paradoxus : Cardiocranius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cardiocranius paradoxus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cardiocranius_paradoxus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1041411;
}
