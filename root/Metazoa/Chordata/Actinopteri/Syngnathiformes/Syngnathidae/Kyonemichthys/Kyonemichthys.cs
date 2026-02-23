using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Kyonemichthys;

/// <summary>
/// Abstract class for Kyonemichthys (genus).
/// NCBI TaxId: 2936854
/// </summary>
public abstract class Kyonemichthys : Syngnathidae, IKyonemichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kyonemichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2936854;

    /// <inheritdoc />
    public virtual string GenusName => "Kyonemichthys";

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
