using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Graueria;

/// <summary>
/// Abstract class for Graueria (genus).
/// NCBI TaxId: 1002784
/// </summary>
public abstract class Graueria : Sylviidae, IGraueria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Graueria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1002784;

    /// <inheritdoc />
    public virtual string GenusName => "Graueria";

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
