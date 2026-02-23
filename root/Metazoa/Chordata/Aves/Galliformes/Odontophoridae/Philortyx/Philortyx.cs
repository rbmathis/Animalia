using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Philortyx;

/// <summary>
/// Abstract class for Philortyx (genus).
/// NCBI TaxId: 1355944
/// </summary>
public abstract class Philortyx : Odontophoridae, IPhilortyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Philortyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1355944;

    /// <inheritdoc />
    public virtual string GenusName => "Philortyx";

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
