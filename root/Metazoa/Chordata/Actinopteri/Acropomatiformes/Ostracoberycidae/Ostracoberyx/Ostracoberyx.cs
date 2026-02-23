using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Ostracoberycidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Ostracoberycidae.Ostracoberyx;

/// <summary>
/// Abstract class for Ostracoberyx (genus).
/// NCBI TaxId: 428448
/// </summary>
public abstract class Ostracoberyx : Ostracoberycidae, IOstracoberyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ostracoberyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 428448;

    /// <inheritdoc />
    public virtual string GenusName => "Ostracoberyx";

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
