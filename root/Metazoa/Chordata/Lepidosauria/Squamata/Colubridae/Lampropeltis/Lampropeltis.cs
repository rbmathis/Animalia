using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Lampropeltis;

/// <summary>
/// Abstract class for Lampropeltis (genus).
/// NCBI TaxId: 94873
/// </summary>
public abstract class Lampropeltis : Colubridae, ILampropeltis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lampropeltis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94873;

    /// <inheritdoc />
    public virtual string GenusName => "Lampropeltis";

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
