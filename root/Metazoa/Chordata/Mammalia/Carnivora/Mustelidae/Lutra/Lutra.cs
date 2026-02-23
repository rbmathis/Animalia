using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Lutra;

/// <summary>
/// Abstract class for Lutra (genus).
/// NCBI TaxId: 9656
/// </summary>
public abstract class Lutra : Mustelidae, ILutra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lutra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9656;

    /// <inheritdoc />
    public virtual string GenusName => "Lutra";

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
