using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Grammomys;

/// <summary>
/// Abstract class for Grammomys (genus).
/// NCBI TaxId: 121588
/// </summary>
public abstract class Grammomys : Muridae, IGrammomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grammomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121588;

    /// <inheritdoc />
    public virtual string GenusName => "Grammomys";

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
