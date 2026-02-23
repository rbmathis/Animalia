using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Artamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Artamidae.Gymnorhina;

/// <summary>
/// Abstract class for Gymnorhina (genus).
/// NCBI TaxId: 9131
/// </summary>
public abstract class Gymnorhina : Artamidae, IGymnorhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnorhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9131;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnorhina";

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
