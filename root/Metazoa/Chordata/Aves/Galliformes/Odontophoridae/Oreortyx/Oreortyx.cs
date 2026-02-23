using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Oreortyx;

/// <summary>
/// Abstract class for Oreortyx (genus).
/// NCBI TaxId: 9027
/// </summary>
public abstract class Oreortyx : Odontophoridae, IOreortyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreortyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9027;

    /// <inheritdoc />
    public virtual string GenusName => "Oreortyx";

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
