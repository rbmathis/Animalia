using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Argyrops;

/// <summary>
/// Abstract class for Argyrops (genus).
/// NCBI TaxId: 119683
/// </summary>
public abstract class Argyrops : Sparidae, IArgyrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Argyrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119683;

    /// <inheritdoc />
    public virtual string GenusName => "Argyrops";

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
