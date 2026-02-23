using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Grammistes;

/// <summary>
/// Abstract class for Grammistes (genus).
/// NCBI TaxId: 270575
/// </summary>
public abstract class Grammistes : Serranidae, IGrammistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grammistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270575;

    /// <inheritdoc />
    public virtual string GenusName => "Grammistes";

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
