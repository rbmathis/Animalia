using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Poecilopsettidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Poecilopsettidae.Poecilopsetta;

/// <summary>
/// Abstract class for Poecilopsetta (genus).
/// NCBI TaxId: 195636
/// </summary>
public abstract class Poecilopsetta : Poecilopsettidae, IPoecilopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poecilopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195636;

    /// <inheritdoc />
    public virtual string GenusName => "Poecilopsetta";

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
