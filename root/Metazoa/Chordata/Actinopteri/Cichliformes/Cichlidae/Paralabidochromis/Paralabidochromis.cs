using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Paralabidochromis;

/// <summary>
/// Abstract class for Paralabidochromis (genus).
/// NCBI TaxId: 51178
/// </summary>
public abstract class Paralabidochromis : Cichlidae, IParalabidochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paralabidochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51178;

    /// <inheritdoc />
    public virtual string GenusName => "Paralabidochromis";

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
