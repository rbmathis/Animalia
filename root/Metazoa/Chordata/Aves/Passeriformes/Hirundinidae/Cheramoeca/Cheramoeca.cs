using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Cheramoeca;

/// <summary>
/// Abstract class for Cheramoeca (genus).
/// NCBI TaxId: 317114
/// </summary>
public abstract class Cheramoeca : Hirundinidae, ICheramoeca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cheramoeca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 317114;

    /// <inheritdoc />
    public virtual string GenusName => "Cheramoeca";

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
