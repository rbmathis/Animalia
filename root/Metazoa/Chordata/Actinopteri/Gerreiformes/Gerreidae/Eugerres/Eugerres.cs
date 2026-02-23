using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae.Eugerres;

/// <summary>
/// Abstract class for Eugerres (genus).
/// NCBI TaxId: 390331
/// </summary>
public abstract class Eugerres : Gerreidae, IEugerres
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eugerres";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390331;

    /// <inheritdoc />
    public virtual string GenusName => "Eugerres";

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
