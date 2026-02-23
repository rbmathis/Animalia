using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Mormopterus;

/// <summary>
/// Abstract class for Mormopterus (genus).
/// NCBI TaxId: 27623
/// </summary>
public abstract class Mormopterus : Molossidae, IMormopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mormopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27623;

    /// <inheritdoc />
    public virtual string GenusName => "Mormopterus";

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
