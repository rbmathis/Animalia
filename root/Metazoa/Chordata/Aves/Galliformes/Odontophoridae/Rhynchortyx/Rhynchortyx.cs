using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Rhynchortyx;

/// <summary>
/// Abstract class for Rhynchortyx (genus).
/// NCBI TaxId: 1355956
/// </summary>
public abstract class Rhynchortyx : Odontophoridae, IRhynchortyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchortyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1355956;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchortyx";

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
