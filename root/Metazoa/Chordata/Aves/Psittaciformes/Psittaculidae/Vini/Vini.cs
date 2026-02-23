using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Vini;

/// <summary>
/// Abstract class for Vini (genus).
/// NCBI TaxId: 176050
/// </summary>
public abstract class Vini : Psittaculidae, IVini
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vini";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176050;

    /// <inheritdoc />
    public virtual string GenusName => "Vini";

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
