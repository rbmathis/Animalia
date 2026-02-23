using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Lanio;

/// <summary>
/// Abstract class for Lanio (genus).
/// NCBI TaxId: 62216
/// </summary>
public abstract class Lanio : Thraupidae, ILanio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lanio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62216;

    /// <inheritdoc />
    public virtual string GenusName => "Lanio";

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
