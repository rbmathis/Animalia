using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Soleichthys;

/// <summary>
/// Abstract class for Soleichthys (genus).
/// NCBI TaxId: 1286174
/// </summary>
public abstract class Soleichthys : Soleidae, ISoleichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Soleichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1286174;

    /// <inheritdoc />
    public virtual string GenusName => "Soleichthys";

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
