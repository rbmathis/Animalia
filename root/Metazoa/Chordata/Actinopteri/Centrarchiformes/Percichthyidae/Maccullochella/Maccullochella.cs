using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae.Maccullochella;

/// <summary>
/// Abstract class for Maccullochella (genus).
/// NCBI TaxId: 135758
/// </summary>
public abstract class Maccullochella : Percichthyidae, IMaccullochella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Maccullochella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135758;

    /// <inheritdoc />
    public virtual string GenusName => "Maccullochella";

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
