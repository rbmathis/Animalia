using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Caristiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Caristiidae.Caristius;

/// <summary>
/// Abstract class for Caristius (genus).
/// NCBI TaxId: 490313
/// </summary>
public abstract class Caristius : Caristiidae, ICaristius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caristius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490313;

    /// <inheritdoc />
    public virtual string GenusName => "Caristius";

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
