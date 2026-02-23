using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Cristiceps;

/// <summary>
/// Abstract class for Cristiceps (genus).
/// NCBI TaxId: 879809
/// </summary>
public abstract class Cristiceps : Clinidae, ICristiceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cristiceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879809;

    /// <inheritdoc />
    public virtual string GenusName => "Cristiceps";

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
