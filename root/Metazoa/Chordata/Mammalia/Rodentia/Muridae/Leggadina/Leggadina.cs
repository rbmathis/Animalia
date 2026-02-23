using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Leggadina;

/// <summary>
/// Abstract class for Leggadina (genus).
/// NCBI TaxId: 81934
/// </summary>
public abstract class Leggadina : Muridae, ILeggadina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leggadina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81934;

    /// <inheritdoc />
    public virtual string GenusName => "Leggadina";

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
