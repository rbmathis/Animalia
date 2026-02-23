using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Gymnarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Gymnarchidae.Gymnarchus;

/// <summary>
/// Abstract class for Gymnarchus (genus).
/// NCBI TaxId: 42647
/// </summary>
public abstract class Gymnarchus : Gymnarchidae, IGymnarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42647;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnarchus";

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
