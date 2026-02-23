using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Chaenomugil;

/// <summary>
/// Abstract class for Chaenomugil (genus).
/// NCBI TaxId: 1040948
/// </summary>
public abstract class Chaenomugil : Mugilidae, IChaenomugil
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaenomugil";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1040948;

    /// <inheritdoc />
    public virtual string GenusName => "Chaenomugil";

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
