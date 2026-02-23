using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chuco;

/// <summary>
/// Abstract class for Chuco (genus).
/// NCBI TaxId: 1830339
/// </summary>
public abstract class Chuco : Cichlidae, IChuco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chuco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1830339;

    /// <inheritdoc />
    public virtual string GenusName => "Chuco";

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
