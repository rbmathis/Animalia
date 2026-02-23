using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Pteromys;

/// <summary>
/// Abstract class for Pteromys (genus).
/// NCBI TaxId: 55151
/// </summary>
public abstract class Pteromys : Sciuridae, IPteromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pteromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55151;

    /// <inheritdoc />
    public virtual string GenusName => "Pteromys";

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
