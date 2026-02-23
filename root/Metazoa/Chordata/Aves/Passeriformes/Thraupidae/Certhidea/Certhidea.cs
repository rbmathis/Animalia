using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Certhidea;

/// <summary>
/// Abstract class for Certhidea (genus).
/// NCBI TaxId: 48879
/// </summary>
public abstract class Certhidea : Thraupidae, ICerthidea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Certhidea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48879;

    /// <inheritdoc />
    public virtual string GenusName => "Certhidea";

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
