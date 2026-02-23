using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Paraneetroplus;

/// <summary>
/// Abstract class for Paraneetroplus (genus).
/// NCBI TaxId: 63179
/// </summary>
public abstract class Paraneetroplus : Cichlidae, IParaneetroplus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraneetroplus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 63179;

    /// <inheritdoc />
    public virtual string GenusName => "Paraneetroplus";

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
