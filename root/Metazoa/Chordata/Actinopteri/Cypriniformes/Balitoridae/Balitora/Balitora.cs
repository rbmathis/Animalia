using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Balitora;

/// <summary>
/// Abstract class for Balitora (genus).
/// NCBI TaxId: 341102
/// </summary>
public abstract class Balitora : Balitoridae, IBalitora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Balitora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 341102;

    /// <inheritdoc />
    public virtual string GenusName => "Balitora";

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
