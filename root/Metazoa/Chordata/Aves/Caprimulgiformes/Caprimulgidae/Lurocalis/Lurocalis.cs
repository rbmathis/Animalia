using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Lurocalis;

/// <summary>
/// Abstract class for Lurocalis (genus).
/// NCBI TaxId: 382312
/// </summary>
public abstract class Lurocalis : Caprimulgidae, ILurocalis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lurocalis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 382312;

    /// <inheritdoc />
    public virtual string GenusName => "Lurocalis";

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
