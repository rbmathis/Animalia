using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Psitteuteles;

/// <summary>
/// Abstract class for Psitteuteles (genus).
/// NCBI TaxId: 176073
/// </summary>
public abstract class Psitteuteles : Psittaculidae, IPsitteuteles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psitteuteles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176073;

    /// <inheritdoc />
    public virtual string GenusName => "Psitteuteles";

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
