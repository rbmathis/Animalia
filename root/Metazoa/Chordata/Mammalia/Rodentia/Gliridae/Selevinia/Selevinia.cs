using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Selevinia;

/// <summary>
/// Abstract class for Selevinia (genus).
/// NCBI TaxId: 3231041
/// </summary>
public abstract class Selevinia : Gliridae, ISelevinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Selevinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3231041;

    /// <inheritdoc />
    public virtual string GenusName => "Selevinia";

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
