using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Cyrtonyx;

/// <summary>
/// Abstract class for Cyrtonyx (genus).
/// NCBI TaxId: 9016
/// </summary>
public abstract class Cyrtonyx : Odontophoridae, ICyrtonyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyrtonyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9016;

    /// <inheritdoc />
    public virtual string GenusName => "Cyrtonyx";

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
