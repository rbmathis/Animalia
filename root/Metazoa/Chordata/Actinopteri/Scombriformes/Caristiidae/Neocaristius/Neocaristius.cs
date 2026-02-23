using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Caristiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Caristiidae.Neocaristius;

/// <summary>
/// Abstract class for Neocaristius (genus).
/// NCBI TaxId: 2578395
/// </summary>
public abstract class Neocaristius : Caristiidae, INeocaristius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neocaristius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578395;

    /// <inheritdoc />
    public virtual string GenusName => "Neocaristius";

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
