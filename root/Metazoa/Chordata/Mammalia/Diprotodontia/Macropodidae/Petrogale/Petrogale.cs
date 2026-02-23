using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Petrogale;

/// <summary>
/// Abstract class for Petrogale (genus).
/// NCBI TaxId: 9324
/// </summary>
public abstract class Petrogale : Macropodidae, IPetrogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petrogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9324;

    /// <inheritdoc />
    public virtual string GenusName => "Petrogale";

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
