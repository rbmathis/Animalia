using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Ozichthys;

/// <summary>
/// Abstract class for Ozichthys (genus).
/// NCBI TaxId: 2578399
/// </summary>
public abstract class Ozichthys : Apogonidae, IOzichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ozichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578399;

    /// <inheritdoc />
    public virtual string GenusName => "Ozichthys";

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
