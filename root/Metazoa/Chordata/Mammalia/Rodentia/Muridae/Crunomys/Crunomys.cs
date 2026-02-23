using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Crunomys;

/// <summary>
/// Abstract class for Crunomys (genus).
/// NCBI TaxId: 349702
/// </summary>
public abstract class Crunomys : Muridae, ICrunomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crunomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 349702;

    /// <inheritdoc />
    public virtual string GenusName => "Crunomys";

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
