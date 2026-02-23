using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Atelopus;

/// <summary>
/// Abstract class for Atelopus (genus).
/// NCBI TaxId: 47578
/// </summary>
public abstract class Atelopus : Bufonidae, IAtelopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atelopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47578;

    /// <inheritdoc />
    public virtual string GenusName => "Atelopus";

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
