using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Einara;

/// <summary>
/// Abstract class for Einara (genus).
/// NCBI TaxId: 1868728
/// </summary>
public abstract class Einara : Alepocephalidae, IEinara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Einara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1868728;

    /// <inheritdoc />
    public virtual string GenusName => "Einara";

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
