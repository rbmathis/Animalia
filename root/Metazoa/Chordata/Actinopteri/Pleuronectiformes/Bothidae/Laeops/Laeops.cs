using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Laeops;

/// <summary>
/// Abstract class for Laeops (genus).
/// NCBI TaxId: 195618
/// </summary>
public abstract class Laeops : Bothidae, ILaeops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laeops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195618;

    /// <inheritdoc />
    public virtual string GenusName => "Laeops";

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
