using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Boops;

/// <summary>
/// Abstract class for Boops (genus).
/// NCBI TaxId: 36218
/// </summary>
public abstract class Boops : Sparidae, IBoops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36218;

    /// <inheritdoc />
    public virtual string GenusName => "Boops";

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
