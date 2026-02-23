using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Hexanematichthys;

/// <summary>
/// Abstract class for Hexanematichthys (genus).
/// NCBI TaxId: 591301
/// </summary>
public abstract class Hexanematichthys : Ariidae, IHexanematichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hexanematichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 591301;

    /// <inheritdoc />
    public virtual string GenusName => "Hexanematichthys";

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
