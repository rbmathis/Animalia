using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Rhynchonycteris;

/// <summary>
/// Abstract class for Rhynchonycteris (genus).
/// NCBI TaxId: 249016
/// </summary>
public abstract class Rhynchonycteris : Emballonuridae, IRhynchonycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchonycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 249016;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchonycteris";

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
