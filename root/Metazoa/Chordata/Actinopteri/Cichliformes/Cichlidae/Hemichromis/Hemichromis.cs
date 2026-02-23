using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Hemichromis;

/// <summary>
/// Abstract class for Hemichromis (genus).
/// NCBI TaxId: 50797
/// </summary>
public abstract class Hemichromis : Cichlidae, IHemichromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemichromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50797;

    /// <inheritdoc />
    public virtual string GenusName => "Hemichromis";

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
