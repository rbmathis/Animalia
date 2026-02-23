using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Triglachromis;

/// <summary>
/// Abstract class for Triglachromis (genus).
/// NCBI TaxId: 34812
/// </summary>
public abstract class Triglachromis : Cichlidae, ITriglachromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Triglachromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34812;

    /// <inheritdoc />
    public virtual string GenusName => "Triglachromis";

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
