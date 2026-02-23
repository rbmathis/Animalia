using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Lepidopygia;

/// <summary>
/// Abstract class for Lepidopygia (genus).
/// NCBI TaxId: 2231778
/// </summary>
public abstract class Lepidopygia : Estrildidae, ILepidopygia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidopygia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2231778;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidopygia";

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
