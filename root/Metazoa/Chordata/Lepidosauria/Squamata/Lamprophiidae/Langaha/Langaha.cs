using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Langaha;

/// <summary>
/// Abstract class for Langaha (genus).
/// NCBI TaxId: 224553
/// </summary>
public abstract class Langaha : Lamprophiidae, ILangaha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Langaha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224553;

    /// <inheritdoc />
    public virtual string GenusName => "Langaha";

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
