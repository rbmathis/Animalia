using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Mitu;

/// <summary>
/// Abstract class for Mitu (genus).
/// NCBI TaxId: 125062
/// </summary>
public abstract class Mitu : Cracidae, IMitu
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mitu";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125062;

    /// <inheritdoc />
    public virtual string GenusName => "Mitu";

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
