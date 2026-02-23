using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Achiridae.Hypoclinemus;

/// <summary>
/// Abstract class for Hypoclinemus (genus).
/// NCBI TaxId: 329470
/// </summary>
public abstract class Hypoclinemus : Achiridae, IHypoclinemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypoclinemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329470;

    /// <inheritdoc />
    public virtual string GenusName => "Hypoclinemus";

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
