using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Dagetichthys;

/// <summary>
/// Abstract class for Dagetichthys (genus).
/// NCBI TaxId: 1740823
/// </summary>
public abstract class Dagetichthys : Soleidae, IDagetichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dagetichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1740823;

    /// <inheritdoc />
    public virtual string GenusName => "Dagetichthys";

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
