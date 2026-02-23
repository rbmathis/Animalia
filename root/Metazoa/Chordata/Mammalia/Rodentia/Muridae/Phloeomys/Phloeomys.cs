using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Phloeomys;

/// <summary>
/// Abstract class for Phloeomys (genus).
/// NCBI TaxId: 248812
/// </summary>
public abstract class Phloeomys : Muridae, IPhloeomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phloeomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248812;

    /// <inheritdoc />
    public virtual string GenusName => "Phloeomys";

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
