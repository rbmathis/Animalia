using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Scartichthys;

/// <summary>
/// Abstract class for Scartichthys (genus).
/// NCBI TaxId: 1379467
/// </summary>
public abstract class Scartichthys : Blenniidae, IScartichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scartichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1379467;

    /// <inheritdoc />
    public virtual string GenusName => "Scartichthys";

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
