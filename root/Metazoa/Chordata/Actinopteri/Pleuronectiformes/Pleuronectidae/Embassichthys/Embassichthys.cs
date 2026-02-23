using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Embassichthys;

/// <summary>
/// Abstract class for Embassichthys (genus).
/// NCBI TaxId: 320375
/// </summary>
public abstract class Embassichthys : Pleuronectidae, IEmbassichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Embassichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320375;

    /// <inheritdoc />
    public virtual string GenusName => "Embassichthys";

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
