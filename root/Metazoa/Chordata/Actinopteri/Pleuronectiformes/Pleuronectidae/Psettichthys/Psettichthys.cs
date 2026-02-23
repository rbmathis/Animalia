using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Psettichthys;

/// <summary>
/// Abstract class for Psettichthys (genus).
/// NCBI TaxId: 195638
/// </summary>
public abstract class Psettichthys : Pleuronectidae, IPsettichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psettichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195638;

    /// <inheritdoc />
    public virtual string GenusName => "Psettichthys";

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
