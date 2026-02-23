using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Pterogymnus;

/// <summary>
/// Abstract class for Pterogymnus (genus).
/// NCBI TaxId: 119741
/// </summary>
public abstract class Pterogymnus : Sparidae, IPterogymnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterogymnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119741;

    /// <inheritdoc />
    public virtual string GenusName => "Pterogymnus";

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
