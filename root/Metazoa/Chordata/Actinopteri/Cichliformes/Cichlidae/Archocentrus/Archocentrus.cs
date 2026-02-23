using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Archocentrus;

/// <summary>
/// Abstract class for Archocentrus (genus).
/// NCBI TaxId: 61816
/// </summary>
public abstract class Archocentrus : Cichlidae, IArchocentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Archocentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61816;

    /// <inheritdoc />
    public virtual string GenusName => "Archocentrus";

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
