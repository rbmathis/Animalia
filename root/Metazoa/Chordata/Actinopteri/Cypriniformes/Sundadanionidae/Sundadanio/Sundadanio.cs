using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Sundadanionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Sundadanionidae.Sundadanio;

/// <summary>
/// Abstract class for Sundadanio (genus).
/// NCBI TaxId: 432425
/// </summary>
public abstract class Sundadanio : Sundadanionidae, ISundadanio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sundadanio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 432425;

    /// <inheritdoc />
    public virtual string GenusName => "Sundadanio";

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
