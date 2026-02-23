using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Parazenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Parazenidae.Stethopristes;

/// <summary>
/// Abstract class for Stethopristes (genus).
/// NCBI TaxId: 2898410
/// </summary>
public abstract class Stethopristes : Parazenidae, IStethopristes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stethopristes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2898410;

    /// <inheritdoc />
    public virtual string GenusName => "Stethopristes";

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
