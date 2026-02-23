using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Phaenicophilus;

/// <summary>
/// Abstract class for Phaenicophilus (genus).
/// NCBI TaxId: 62232
/// </summary>
public abstract class Phaenicophilus : Thraupidae, IPhaenicophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phaenicophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62232;

    /// <inheritdoc />
    public virtual string GenusName => "Phaenicophilus";

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
