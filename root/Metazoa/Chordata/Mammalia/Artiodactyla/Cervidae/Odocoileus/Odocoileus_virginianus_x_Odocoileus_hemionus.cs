namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Odocoileus;

/// <summary>
/// Species: Odocoileus virginianus x Odocoileus hemionus
/// NCBI TaxId: 2759971
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Odocoileus_virginianus_x_Odocoileus_hemionus : Odocoileus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Odocoileus virginianus x Odocoileus hemionus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Odocoileus_virginianus_x_Odocoileus_hemionus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2759971;
}
