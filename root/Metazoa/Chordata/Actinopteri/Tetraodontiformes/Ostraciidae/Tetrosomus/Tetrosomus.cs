using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.Tetrosomus;

/// <summary>
/// Abstract class for Tetrosomus (genus).
/// NCBI TaxId: 245708
/// </summary>
public abstract class Tetrosomus : Ostraciidae, ITetrosomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetrosomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245708;

    /// <inheritdoc />
    public virtual string GenusName => "Tetrosomus";

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
