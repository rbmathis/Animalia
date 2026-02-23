using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Caristiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Caristiidae.Paracaristius;

/// <summary>
/// Abstract class for Paracaristius (genus).
/// NCBI TaxId: 473357
/// </summary>
public abstract class Paracaristius : Caristiidae, IParacaristius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paracaristius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 473357;

    /// <inheritdoc />
    public virtual string GenusName => "Paracaristius";

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
