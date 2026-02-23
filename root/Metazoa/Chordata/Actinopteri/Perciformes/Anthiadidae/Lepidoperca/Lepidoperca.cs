using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Lepidoperca;

/// <summary>
/// Abstract class for Lepidoperca (genus).
/// NCBI TaxId: 2578382
/// </summary>
public abstract class Lepidoperca : Anthiadidae, ILepidoperca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidoperca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578382;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidoperca";

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
