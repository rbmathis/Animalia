using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Cerdocyon;

/// <summary>
/// Abstract class for Cerdocyon (genus).
/// NCBI TaxId: 1316009
/// </summary>
public abstract class Cerdocyon : Canidae, ICerdocyon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cerdocyon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1316009;

    /// <inheritdoc />
    public virtual string GenusName => "Cerdocyon";

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
