using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Brachiones;

/// <summary>
/// Abstract class for Brachiones (genus).
/// NCBI TaxId: 504101
/// </summary>
public abstract class Brachiones : Muridae, IBrachiones
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachiones";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 504101;

    /// <inheritdoc />
    public virtual string GenusName => "Brachiones";

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
