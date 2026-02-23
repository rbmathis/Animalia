using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Acanthopagrus;

/// <summary>
/// Abstract class for Acanthopagrus (genus).
/// NCBI TaxId: 8176
/// </summary>
public abstract class Acanthopagrus : Sparidae, IAcanthopagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthopagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8176;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthopagrus";

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
