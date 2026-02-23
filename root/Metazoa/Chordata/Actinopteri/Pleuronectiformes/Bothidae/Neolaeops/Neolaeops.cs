using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Neolaeops;

/// <summary>
/// Abstract class for Neolaeops (genus).
/// NCBI TaxId: 366889
/// </summary>
public abstract class Neolaeops : Bothidae, INeolaeops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neolaeops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 366889;

    /// <inheritdoc />
    public virtual string GenusName => "Neolaeops";

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
