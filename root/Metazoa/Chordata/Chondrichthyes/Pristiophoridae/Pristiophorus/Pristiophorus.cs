using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Pristiophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Pristiophoridae.Pristiophorus;

/// <summary>
/// Abstract class for Pristiophorus (genus).
/// NCBI TaxId: 55134
/// </summary>
public abstract class Pristiophorus : Pristiophoridae, IPristiophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pristiophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55134;

    /// <inheritdoc />
    public virtual string GenusName => "Pristiophorus";

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
