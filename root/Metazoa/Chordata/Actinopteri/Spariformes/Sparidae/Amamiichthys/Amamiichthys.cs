using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Amamiichthys;

/// <summary>
/// Abstract class for Amamiichthys (genus).
/// NCBI TaxId: 3344777
/// </summary>
public abstract class Amamiichthys : Sparidae, IAmamiichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amamiichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3344777;

    /// <inheritdoc />
    public virtual string GenusName => "Amamiichthys";

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
