using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Heliornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Heliornithidae.Heliopais;

/// <summary>
/// Abstract class for Heliopais (genus).
/// NCBI TaxId: 382648
/// </summary>
public abstract class Heliopais : Heliornithidae, IHeliopais
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heliopais";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 382648;

    /// <inheritdoc />
    public virtual string GenusName => "Heliopais";

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
