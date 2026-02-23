using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Leopoldamys;

/// <summary>
/// Abstract class for Leopoldamys (genus).
/// NCBI TaxId: 41266
/// </summary>
public abstract class Leopoldamys : Muridae, ILeopoldamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leopoldamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 41266;

    /// <inheritdoc />
    public virtual string GenusName => "Leopoldamys";

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
