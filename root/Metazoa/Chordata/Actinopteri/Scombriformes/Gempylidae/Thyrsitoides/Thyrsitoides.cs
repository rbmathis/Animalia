using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Thyrsitoides;

/// <summary>
/// Abstract class for Thyrsitoides (genus).
/// NCBI TaxId: 1219346
/// </summary>
public abstract class Thyrsitoides : Gempylidae, IThyrsitoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thyrsitoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1219346;

    /// <inheritdoc />
    public virtual string GenusName => "Thyrsitoides";

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
