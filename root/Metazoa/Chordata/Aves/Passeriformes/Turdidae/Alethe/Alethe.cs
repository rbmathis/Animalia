using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Alethe;

/// <summary>
/// Abstract class for Alethe (genus).
/// NCBI TaxId: 197520
/// </summary>
public abstract class Alethe : Turdidae, IAlethe
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alethe";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 197520;

    /// <inheritdoc />
    public virtual string GenusName => "Alethe";

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
