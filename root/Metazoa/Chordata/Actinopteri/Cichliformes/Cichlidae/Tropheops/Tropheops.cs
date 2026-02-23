using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tropheops;

/// <summary>
/// Abstract class for Tropheops (genus).
/// NCBI TaxId: 702376
/// </summary>
public abstract class Tropheops : Cichlidae, ITropheops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tropheops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 702376;

    /// <inheritdoc />
    public virtual string GenusName => "Tropheops";

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
