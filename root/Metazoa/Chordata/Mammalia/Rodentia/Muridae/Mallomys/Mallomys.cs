using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mallomys;

/// <summary>
/// Abstract class for Mallomys (genus).
/// NCBI TaxId: 442579
/// </summary>
public abstract class Mallomys : Muridae, IMallomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mallomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 442579;

    /// <inheritdoc />
    public virtual string GenusName => "Mallomys";

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
