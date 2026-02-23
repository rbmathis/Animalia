using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Thysochromis;

/// <summary>
/// Abstract class for Thysochromis (genus).
/// NCBI TaxId: 97003
/// </summary>
public abstract class Thysochromis : Cichlidae, IThysochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thysochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 97003;

    /// <inheritdoc />
    public virtual string GenusName => "Thysochromis";

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
