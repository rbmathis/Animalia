using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Nyassachromis;

/// <summary>
/// Abstract class for Nyassachromis (genus).
/// NCBI TaxId: 451873
/// </summary>
public abstract class Nyassachromis : Cichlidae, INyassachromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyassachromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 451873;

    /// <inheritdoc />
    public virtual string GenusName => "Nyassachromis";

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
