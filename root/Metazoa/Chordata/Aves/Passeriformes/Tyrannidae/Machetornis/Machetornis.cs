using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Machetornis;

/// <summary>
/// Abstract class for Machetornis (genus).
/// NCBI TaxId: 495240
/// </summary>
public abstract class Machetornis : Tyrannidae, IMachetornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Machetornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495240;

    /// <inheritdoc />
    public virtual string GenusName => "Machetornis";

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
