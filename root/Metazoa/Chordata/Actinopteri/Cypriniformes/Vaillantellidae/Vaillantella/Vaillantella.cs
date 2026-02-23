using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Vaillantellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Vaillantellidae.Vaillantella;

/// <summary>
/// Abstract class for Vaillantella (genus).
/// NCBI TaxId: 357289
/// </summary>
public abstract class Vaillantella : Vaillantellidae, IVaillantella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vaillantella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 357289;

    /// <inheritdoc />
    public virtual string GenusName => "Vaillantella";

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
