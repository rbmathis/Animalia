using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Meriones;

/// <summary>
/// Abstract class for Meriones (genus).
/// NCBI TaxId: 10046
/// </summary>
public abstract class Meriones : Muridae, IMeriones
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Meriones";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10046;

    /// <inheritdoc />
    public virtual string GenusName => "Meriones";

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
