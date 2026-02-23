using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Nesoryzomys;

/// <summary>
/// Abstract class for Nesoryzomys (genus).
/// NCBI TaxId: 89123
/// </summary>
public abstract class Nesoryzomys : Cricetidae, INesoryzomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesoryzomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89123;

    /// <inheritdoc />
    public virtual string GenusName => "Nesoryzomys";

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
