using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cyclopharynx;

/// <summary>
/// Abstract class for Cyclopharynx (genus).
/// NCBI TaxId: 158762
/// </summary>
public abstract class Cyclopharynx : Cichlidae, ICyclopharynx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclopharynx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 158762;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclopharynx";

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
