using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Variabilichromis;

/// <summary>
/// Abstract class for Variabilichromis (genus).
/// NCBI TaxId: 272715
/// </summary>
public abstract class Variabilichromis : Cichlidae, IVariabilichromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Variabilichromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 272715;

    /// <inheritdoc />
    public virtual string GenusName => "Variabilichromis";

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
