using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Pseudalectrias;

/// <summary>
/// Abstract class for Pseudalectrias (genus).
/// NCBI TaxId: 1638159
/// </summary>
public abstract class Pseudalectrias : Stichaeidae, IPseudalectrias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudalectrias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1638159;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudalectrias";

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
