using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Nimbochromis;

/// <summary>
/// Abstract class for Nimbochromis (genus).
/// NCBI TaxId: 136861
/// </summary>
public abstract class Nimbochromis : Cichlidae, INimbochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nimbochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 136861;

    /// <inheritdoc />
    public virtual string GenusName => "Nimbochromis";

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
