using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Siokunichthys;

/// <summary>
/// Abstract class for Siokunichthys (genus).
/// NCBI TaxId: 1914738
/// </summary>
public abstract class Siokunichthys : Syngnathidae, ISiokunichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Siokunichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1914738;

    /// <inheritdoc />
    public virtual string GenusName => "Siokunichthys";

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
