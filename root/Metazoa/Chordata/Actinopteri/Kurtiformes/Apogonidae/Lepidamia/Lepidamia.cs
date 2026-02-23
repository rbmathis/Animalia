using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Lepidamia;

/// <summary>
/// Abstract class for Lepidamia (genus).
/// NCBI TaxId: 638289
/// </summary>
public abstract class Lepidamia : Apogonidae, ILepidamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 638289;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidamia";

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
