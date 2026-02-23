using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae.Stipiturus;

/// <summary>
/// Abstract class for Stipiturus (genus).
/// NCBI TaxId: 266392
/// </summary>
public abstract class Stipiturus : Maluridae, IStipiturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stipiturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266392;

    /// <inheritdoc />
    public virtual string GenusName => "Stipiturus";

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
