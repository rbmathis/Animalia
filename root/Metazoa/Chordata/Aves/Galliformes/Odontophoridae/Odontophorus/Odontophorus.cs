using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Odontophorus;

/// <summary>
/// Abstract class for Odontophorus (genus).
/// NCBI TaxId: 224314
/// </summary>
public abstract class Odontophorus : Odontophoridae, IOdontophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odontophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224314;

    /// <inheritdoc />
    public virtual string GenusName => "Odontophorus";

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
