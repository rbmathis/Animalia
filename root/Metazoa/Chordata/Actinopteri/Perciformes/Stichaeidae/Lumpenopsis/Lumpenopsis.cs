using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Lumpenopsis;

/// <summary>
/// Abstract class for Lumpenopsis (genus).
/// NCBI TaxId: 1804619
/// </summary>
public abstract class Lumpenopsis : Stichaeidae, ILumpenopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lumpenopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1804619;

    /// <inheritdoc />
    public virtual string GenusName => "Lumpenopsis";

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
