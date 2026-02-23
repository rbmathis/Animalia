using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Microstomus;

/// <summary>
/// Abstract class for Microstomus (genus).
/// NCBI TaxId: 89056
/// </summary>
public abstract class Microstomus : Pleuronectidae, IMicrostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microstomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89056;

    /// <inheritdoc />
    public virtual string GenusName => "Microstomus";

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
