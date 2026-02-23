using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Zebrias;

/// <summary>
/// Abstract class for Zebrias (genus).
/// NCBI TaxId: 244453
/// </summary>
public abstract class Zebrias : Soleidae, IZebrias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zebrias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 244453;

    /// <inheritdoc />
    public virtual string GenusName => "Zebrias";

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
