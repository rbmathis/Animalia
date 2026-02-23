using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae.Holtbyrnia;

/// <summary>
/// Abstract class for Holtbyrnia (genus).
/// NCBI TaxId: 473370
/// </summary>
public abstract class Holtbyrnia : Platytroctidae, IHoltbyrnia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Holtbyrnia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 473370;

    /// <inheritdoc />
    public virtual string GenusName => "Holtbyrnia";

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
