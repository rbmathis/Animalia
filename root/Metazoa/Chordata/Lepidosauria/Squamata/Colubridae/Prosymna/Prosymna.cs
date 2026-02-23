using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Prosymna;

/// <summary>
/// Abstract class for Prosymna (genus).
/// NCBI TaxId: 224564
/// </summary>
public abstract class Prosymna : Colubridae, IProsymna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prosymna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224564;

    /// <inheritdoc />
    public virtual string GenusName => "Prosymna";

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
