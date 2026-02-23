using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Venefica;

/// <summary>
/// Abstract class for Venefica (genus).
/// NCBI TaxId: 391215
/// </summary>
public abstract class Venefica : Nettastomatidae, IVenefica
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Venefica";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 391215;

    /// <inheritdoc />
    public virtual string GenusName => "Venefica";

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
