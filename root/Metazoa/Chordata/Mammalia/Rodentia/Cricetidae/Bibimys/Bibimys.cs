using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Bibimys;

/// <summary>
/// Abstract class for Bibimys (genus).
/// NCBI TaxId: 241100
/// </summary>
public abstract class Bibimys : Cricetidae, IBibimys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bibimys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241100;

    /// <inheritdoc />
    public virtual string GenusName => "Bibimys";

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
