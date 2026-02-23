using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Dactylopus;

/// <summary>
/// Abstract class for Dactylopus (genus).
/// NCBI TaxId: 587047
/// </summary>
public abstract class Dactylopus : Callionymidae, IDactylopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dactylopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 587047;

    /// <inheritdoc />
    public virtual string GenusName => "Dactylopus";

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
