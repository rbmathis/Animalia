using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Ariommatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Ariommatidae.Ariomma;

/// <summary>
/// Abstract class for Ariomma (genus).
/// NCBI TaxId: 316124
/// </summary>
public abstract class Ariomma : Ariommatidae, IAriomma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ariomma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 316124;

    /// <inheritdoc />
    public virtual string GenusName => "Ariomma";

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
