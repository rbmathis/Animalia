using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Rhinomugil;

/// <summary>
/// Abstract class for Rhinomugil (genus).
/// NCBI TaxId: 1040952
/// </summary>
public abstract class Rhinomugil : Mugilidae, IRhinomugil
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinomugil";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1040952;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinomugil";

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
