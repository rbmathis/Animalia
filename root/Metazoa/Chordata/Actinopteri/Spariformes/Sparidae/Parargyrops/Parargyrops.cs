using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Parargyrops;

/// <summary>
/// Abstract class for Parargyrops (genus).
/// NCBI TaxId: 255643
/// </summary>
public abstract class Parargyrops : Sparidae, IParargyrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parargyrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 255643;

    /// <inheritdoc />
    public virtual string GenusName => "Parargyrops";

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
