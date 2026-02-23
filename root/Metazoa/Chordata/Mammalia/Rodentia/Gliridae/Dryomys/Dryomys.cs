using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Dryomys;

/// <summary>
/// Abstract class for Dryomys (genus).
/// NCBI TaxId: 55144
/// </summary>
public abstract class Dryomys : Gliridae, IDryomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dryomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55144;

    /// <inheritdoc />
    public virtual string GenusName => "Dryomys";

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
