using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Callipepla;

/// <summary>
/// Abstract class for Callipepla (genus).
/// NCBI TaxId: 9008
/// </summary>
public abstract class Callipepla : Odontophoridae, ICallipepla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callipepla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9008;

    /// <inheritdoc />
    public virtual string GenusName => "Callipepla";

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
