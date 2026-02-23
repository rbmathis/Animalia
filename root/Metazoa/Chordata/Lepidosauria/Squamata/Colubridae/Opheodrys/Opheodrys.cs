using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Opheodrys;

/// <summary>
/// Abstract class for Opheodrys (genus).
/// NCBI TaxId: 186590
/// </summary>
public abstract class Opheodrys : Colubridae, IOpheodrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opheodrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186590;

    /// <inheritdoc />
    public virtual string GenusName => "Opheodrys";

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
