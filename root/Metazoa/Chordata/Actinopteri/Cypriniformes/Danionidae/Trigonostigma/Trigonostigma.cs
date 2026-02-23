using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Trigonostigma;

/// <summary>
/// Abstract class for Trigonostigma (genus).
/// NCBI TaxId: 345259
/// </summary>
public abstract class Trigonostigma : Danionidae, ITrigonostigma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trigonostigma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 345259;

    /// <inheritdoc />
    public virtual string GenusName => "Trigonostigma";

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
