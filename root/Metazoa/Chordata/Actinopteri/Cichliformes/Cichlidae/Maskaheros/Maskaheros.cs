using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Maskaheros;

/// <summary>
/// Abstract class for Maskaheros (genus).
/// NCBI TaxId: 1830342
/// </summary>
public abstract class Maskaheros : Cichlidae, IMaskaheros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Maskaheros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1830342;

    /// <inheritdoc />
    public virtual string GenusName => "Maskaheros";

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
