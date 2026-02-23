using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Niwaella;

/// <summary>
/// Abstract class for Niwaella (genus).
/// NCBI TaxId: 118137
/// </summary>
public abstract class Niwaella : Cobitidae, INiwaella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Niwaella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118137;

    /// <inheritdoc />
    public virtual string GenusName => "Niwaella";

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
