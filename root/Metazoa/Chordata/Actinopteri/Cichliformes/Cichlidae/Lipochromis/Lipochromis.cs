using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lipochromis;

/// <summary>
/// Abstract class for Lipochromis (genus).
/// NCBI TaxId: 51176
/// </summary>
public abstract class Lipochromis : Cichlidae, ILipochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lipochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51176;

    /// <inheritdoc />
    public virtual string GenusName => "Lipochromis";

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
