using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Osteomugil;

/// <summary>
/// Abstract class for Osteomugil (genus).
/// NCBI TaxId: 435239
/// </summary>
public abstract class Osteomugil : Mugilidae, IOsteomugil
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Osteomugil";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 435239;

    /// <inheritdoc />
    public virtual string GenusName => "Osteomugil";

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
