using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Colinus;

/// <summary>
/// Abstract class for Colinus (genus).
/// NCBI TaxId: 9013
/// </summary>
public abstract class Colinus : Odontophoridae, IColinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9013;

    /// <inheritdoc />
    public virtual string GenusName => "Colinus";

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
