using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Zapogon;

/// <summary>
/// Abstract class for Zapogon (genus).
/// NCBI TaxId: 638294
/// </summary>
public abstract class Zapogon : Apogonidae, IZapogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zapogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 638294;

    /// <inheritdoc />
    public virtual string GenusName => "Zapogon";

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
