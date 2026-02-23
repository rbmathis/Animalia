using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Petrus;

/// <summary>
/// Abstract class for Petrus (genus).
/// NCBI TaxId: 119731
/// </summary>
public abstract class Petrus : Sparidae, IPetrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119731;

    /// <inheritdoc />
    public virtual string GenusName => "Petrus";

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
