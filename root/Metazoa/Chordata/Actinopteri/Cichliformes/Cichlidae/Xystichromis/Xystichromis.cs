using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Xystichromis;

/// <summary>
/// Abstract class for Xystichromis (genus).
/// NCBI TaxId: 51180
/// </summary>
public abstract class Xystichromis : Cichlidae, IXystichromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xystichromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51180;

    /// <inheritdoc />
    public virtual string GenusName => "Xystichromis";

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
