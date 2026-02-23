using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Pseudocalliurichthys;

/// <summary>
/// Abstract class for Pseudocalliurichthys (genus).
/// NCBI TaxId: 1503356
/// </summary>
public abstract class Pseudocalliurichthys : Callionymidae, IPseudocalliurichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocalliurichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1503356;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudocalliurichthys";

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
