using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Cheimerius;

/// <summary>
/// Abstract class for Cheimerius (genus).
/// NCBI TaxId: 119703
/// </summary>
public abstract class Cheimerius : Sparidae, ICheimerius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cheimerius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119703;

    /// <inheritdoc />
    public virtual string GenusName => "Cheimerius";

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
