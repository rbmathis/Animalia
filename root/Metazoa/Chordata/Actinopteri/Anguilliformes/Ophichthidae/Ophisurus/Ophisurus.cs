using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Ophisurus;

/// <summary>
/// Abstract class for Ophisurus (genus).
/// NCBI TaxId: 118156
/// </summary>
public abstract class Ophisurus : Ophichthidae, IOphisurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophisurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118156;

    /// <inheritdoc />
    public virtual string GenusName => "Ophisurus";

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
