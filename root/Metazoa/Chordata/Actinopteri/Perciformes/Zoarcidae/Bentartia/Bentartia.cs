using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Bentartia;

/// <summary>
/// Abstract class for Bentartia (genus).
/// NCBI TaxId: 2048770
/// </summary>
public abstract class Bentartia : Zoarcidae, IBentartia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bentartia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2048770;

    /// <inheritdoc />
    public virtual string GenusName => "Bentartia";

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
