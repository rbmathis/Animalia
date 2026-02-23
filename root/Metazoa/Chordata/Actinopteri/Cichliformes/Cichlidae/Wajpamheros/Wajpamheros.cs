using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Wajpamheros;

/// <summary>
/// Abstract class for Wajpamheros (genus).
/// NCBI TaxId: 1830345
/// </summary>
public abstract class Wajpamheros : Cichlidae, IWajpamheros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Wajpamheros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1830345;

    /// <inheritdoc />
    public virtual string GenusName => "Wajpamheros";

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
