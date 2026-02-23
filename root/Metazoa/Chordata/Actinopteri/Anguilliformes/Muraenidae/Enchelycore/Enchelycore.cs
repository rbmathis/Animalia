using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Enchelycore;

/// <summary>
/// Abstract class for Enchelycore (genus).
/// NCBI TaxId: 426091
/// </summary>
public abstract class Enchelycore : Muraenidae, IEnchelycore
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enchelycore";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 426091;

    /// <inheritdoc />
    public virtual string GenusName => "Enchelycore";

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
