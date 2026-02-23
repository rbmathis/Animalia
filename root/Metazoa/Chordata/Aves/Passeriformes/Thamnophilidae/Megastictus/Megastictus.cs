using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Megastictus;

/// <summary>
/// Abstract class for Megastictus (genus).
/// NCBI TaxId: 288059
/// </summary>
public abstract class Megastictus : Thamnophilidae, IMegastictus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megastictus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288059;

    /// <inheritdoc />
    public virtual string GenusName => "Megastictus";

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
