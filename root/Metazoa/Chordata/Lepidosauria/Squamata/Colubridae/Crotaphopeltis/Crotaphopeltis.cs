using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Crotaphopeltis;

/// <summary>
/// Abstract class for Crotaphopeltis (genus).
/// NCBI TaxId: 186549
/// </summary>
public abstract class Crotaphopeltis : Colubridae, ICrotaphopeltis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crotaphopeltis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186549;

    /// <inheritdoc />
    public virtual string GenusName => "Crotaphopeltis";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
