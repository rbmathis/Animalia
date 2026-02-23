using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Lepidothrix;

/// <summary>
/// Abstract class for Lepidothrix (genus).
/// NCBI TaxId: 321397
/// </summary>
public abstract class Lepidothrix : Pipridae, ILepidothrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidothrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321397;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidothrix";

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
