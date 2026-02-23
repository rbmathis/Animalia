using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Frateromys;

/// <summary>
/// Abstract class for Frateromys (genus).
/// NCBI TaxId: 3049459
/// </summary>
public abstract class Frateromys : Muridae, IFrateromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Frateromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3049459;

    /// <inheritdoc />
    public virtual string GenusName => "Frateromys";

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
