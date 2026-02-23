using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Sphenodontia.Sphenodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Sphenodontia.Sphenodontidae.Sphenodon;

/// <summary>
/// Abstract class for Sphenodon (genus).
/// NCBI TaxId: 8507
/// </summary>
public abstract class Sphenodon : Sphenodontidae, ISphenodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphenodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8507;

    /// <inheritdoc />
    public virtual string GenusName => "Sphenodon";

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
