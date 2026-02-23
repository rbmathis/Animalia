using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Gymnotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Gymnotidae.Electrophorus;

/// <summary>
/// Abstract class for Electrophorus (genus).
/// NCBI TaxId: 8004
/// </summary>
public abstract class Electrophorus : Gymnotidae, IElectrophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Electrophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8004;

    /// <inheritdoc />
    public virtual string GenusName => "Electrophorus";

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
