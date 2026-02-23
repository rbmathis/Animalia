using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Cochlefelis;

/// <summary>
/// Abstract class for Cochlefelis (genus).
/// NCBI TaxId: 591318
/// </summary>
public abstract class Cochlefelis : Ariidae, ICochlefelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cochlefelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 591318;

    /// <inheritdoc />
    public virtual string GenusName => "Cochlefelis";

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
