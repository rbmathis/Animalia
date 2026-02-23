using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Gibbonsia;

/// <summary>
/// Abstract class for Gibbonsia (genus).
/// NCBI TaxId: 57800
/// </summary>
public abstract class Gibbonsia : Clinidae, IGibbonsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gibbonsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57800;

    /// <inheritdoc />
    public virtual string GenusName => "Gibbonsia";

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
