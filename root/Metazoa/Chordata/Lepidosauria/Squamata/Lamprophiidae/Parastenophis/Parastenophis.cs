using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Parastenophis;

/// <summary>
/// Abstract class for Parastenophis (genus).
/// NCBI TaxId: 875664
/// </summary>
public abstract class Parastenophis : Lamprophiidae, IParastenophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parastenophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 875664;

    /// <inheritdoc />
    public virtual string GenusName => "Parastenophis";

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
