using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hapalomys;

/// <summary>
/// Abstract class for Hapalomys (genus).
/// NCBI TaxId: 1156414
/// </summary>
public abstract class Hapalomys : Muridae, IHapalomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hapalomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1156414;

    /// <inheritdoc />
    public virtual string GenusName => "Hapalomys";

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
