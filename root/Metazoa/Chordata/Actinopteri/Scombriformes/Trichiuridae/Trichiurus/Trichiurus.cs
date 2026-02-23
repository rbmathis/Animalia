using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Trichiurus;

/// <summary>
/// Abstract class for Trichiurus (genus).
/// NCBI TaxId: 13732
/// </summary>
public abstract class Trichiurus : Trichiuridae, ITrichiurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichiurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13732;

    /// <inheritdoc />
    public virtual string GenusName => "Trichiurus";

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
