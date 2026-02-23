using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Jinshaia;

/// <summary>
/// Abstract class for Jinshaia (genus).
/// NCBI TaxId: 241445
/// </summary>
public abstract class Jinshaia : Balitoridae, IJinshaia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jinshaia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241445;

    /// <inheritdoc />
    public virtual string GenusName => "Jinshaia";

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
