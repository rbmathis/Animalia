using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae.Malurus;

/// <summary>
/// Abstract class for Malurus (genus).
/// NCBI TaxId: 55806
/// </summary>
public abstract class Malurus : Maluridae, IMalurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55806;

    /// <inheritdoc />
    public virtual string GenusName => "Malurus";

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
