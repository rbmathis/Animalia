using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Esomus;

/// <summary>
/// Abstract class for Esomus (genus).
/// NCBI TaxId: 353258
/// </summary>
public abstract class Esomus : Danionidae, IEsomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Esomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 353258;

    /// <inheritdoc />
    public virtual string GenusName => "Esomus";

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
