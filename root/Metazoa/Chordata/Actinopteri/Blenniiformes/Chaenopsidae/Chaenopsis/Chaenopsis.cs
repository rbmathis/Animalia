using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae.Chaenopsis;

/// <summary>
/// Abstract class for Chaenopsis (genus).
/// NCBI TaxId: 57785
/// </summary>
public abstract class Chaenopsis : Chaenopsidae, IChaenopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaenopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57785;

    /// <inheritdoc />
    public virtual string GenusName => "Chaenopsis";

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
