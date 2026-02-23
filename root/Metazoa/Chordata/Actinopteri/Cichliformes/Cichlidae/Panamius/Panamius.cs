using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Panamius;

/// <summary>
/// Abstract class for Panamius (genus).
/// NCBI TaxId: 762640
/// </summary>
public abstract class Panamius : Cichlidae, IPanamius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Panamius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 762640;

    /// <inheritdoc />
    public virtual string GenusName => "Panamius";

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
