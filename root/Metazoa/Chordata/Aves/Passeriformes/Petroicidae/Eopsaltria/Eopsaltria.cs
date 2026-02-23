using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Eopsaltria;

/// <summary>
/// Abstract class for Eopsaltria (genus).
/// NCBI TaxId: 44317
/// </summary>
public abstract class Eopsaltria : Petroicidae, IEopsaltria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eopsaltria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44317;

    /// <inheritdoc />
    public virtual string GenusName => "Eopsaltria";

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
