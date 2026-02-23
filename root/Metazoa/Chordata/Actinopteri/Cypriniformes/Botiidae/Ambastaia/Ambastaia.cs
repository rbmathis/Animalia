using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Ambastaia;

/// <summary>
/// Abstract class for Ambastaia (genus).
/// NCBI TaxId: 1436200
/// </summary>
public abstract class Ambastaia : Botiidae, IAmbastaia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ambastaia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1436200;

    /// <inheritdoc />
    public virtual string GenusName => "Ambastaia";

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
