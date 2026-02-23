using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Chilorhinophis;

/// <summary>
/// Abstract class for Chilorhinophis (genus).
/// NCBI TaxId: 1543981
/// </summary>
public abstract class Chilorhinophis : Lamprophiidae, IChilorhinophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chilorhinophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1543981;

    /// <inheritdoc />
    public virtual string GenusName => "Chilorhinophis";

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
