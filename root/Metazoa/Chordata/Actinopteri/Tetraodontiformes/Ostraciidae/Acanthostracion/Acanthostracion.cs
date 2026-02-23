using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.Acanthostracion;

/// <summary>
/// Abstract class for Acanthostracion (genus).
/// NCBI TaxId: 587041
/// </summary>
public abstract class Acanthostracion : Ostraciidae, IAcanthostracion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthostracion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 587041;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthostracion";

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
