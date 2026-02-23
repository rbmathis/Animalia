using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae.Parequula;

/// <summary>
/// Abstract class for Parequula (genus).
/// NCBI TaxId: 548268
/// </summary>
public abstract class Parequula : Gerreidae, IParequula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parequula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 548268;

    /// <inheritdoc />
    public virtual string GenusName => "Parequula";

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
