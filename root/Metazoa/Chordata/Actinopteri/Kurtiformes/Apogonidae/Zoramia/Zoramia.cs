using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Zoramia;

/// <summary>
/// Abstract class for Zoramia (genus).
/// NCBI TaxId: 475177
/// </summary>
public abstract class Zoramia : Apogonidae, IZoramia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zoramia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 475177;

    /// <inheritdoc />
    public virtual string GenusName => "Zoramia";

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
