using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Pangio;

/// <summary>
/// Abstract class for Pangio (genus).
/// NCBI TaxId: 127971
/// </summary>
public abstract class Pangio : Cobitidae, IPangio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pangio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 127971;

    /// <inheritdoc />
    public virtual string GenusName => "Pangio";

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
