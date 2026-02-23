using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Heliornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Heliornithidae.Podica;

/// <summary>
/// Abstract class for Podica (genus).
/// NCBI TaxId: 54370
/// </summary>
public abstract class Podica : Heliornithidae, IPodica
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Podica";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54370;

    /// <inheritdoc />
    public virtual string GenusName => "Podica";

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
