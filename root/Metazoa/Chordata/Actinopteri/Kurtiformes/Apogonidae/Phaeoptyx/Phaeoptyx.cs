using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Phaeoptyx;

/// <summary>
/// Abstract class for Phaeoptyx (genus).
/// NCBI TaxId: 588193
/// </summary>
public abstract class Phaeoptyx : Apogonidae, IPhaeoptyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phaeoptyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 588193;

    /// <inheritdoc />
    public virtual string GenusName => "Phaeoptyx";

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
