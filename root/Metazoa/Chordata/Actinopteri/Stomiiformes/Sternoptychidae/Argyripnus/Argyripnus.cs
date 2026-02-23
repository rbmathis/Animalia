using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Argyripnus;

/// <summary>
/// Abstract class for Argyripnus (genus).
/// NCBI TaxId: 2708532
/// </summary>
public abstract class Argyripnus : Sternoptychidae, IArgyripnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Argyripnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2708532;

    /// <inheritdoc />
    public virtual string GenusName => "Argyripnus";

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
