using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.Ostracion;

/// <summary>
/// Abstract class for Ostracion (genus).
/// NCBI TaxId: 94238
/// </summary>
public abstract class Ostracion : Ostraciidae, IOstracion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ostracion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94238;

    /// <inheritdoc />
    public virtual string GenusName => "Ostracion";

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
