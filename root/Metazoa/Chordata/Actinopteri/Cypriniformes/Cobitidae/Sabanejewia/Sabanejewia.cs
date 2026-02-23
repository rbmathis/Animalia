using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Sabanejewia;

/// <summary>
/// Abstract class for Sabanejewia (genus).
/// NCBI TaxId: 66305
/// </summary>
public abstract class Sabanejewia : Cobitidae, ISabanejewia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sabanejewia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 66305;

    /// <inheritdoc />
    public virtual string GenusName => "Sabanejewia";

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
