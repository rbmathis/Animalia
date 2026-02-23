using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Poecilopsettidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Poecilopsettidae.Marleyella;

/// <summary>
/// Abstract class for Marleyella (genus).
/// NCBI TaxId: 990987
/// </summary>
public abstract class Marleyella : Poecilopsettidae, IMarleyella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Marleyella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990987;

    /// <inheritdoc />
    public virtual string GenusName => "Marleyella";

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
