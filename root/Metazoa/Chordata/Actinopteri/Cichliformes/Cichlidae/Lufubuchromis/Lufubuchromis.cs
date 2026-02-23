using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lufubuchromis;

/// <summary>
/// Abstract class for Lufubuchromis (genus).
/// NCBI TaxId: 3132025
/// </summary>
public abstract class Lufubuchromis : Cichlidae, ILufubuchromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lufubuchromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3132025;

    /// <inheritdoc />
    public virtual string GenusName => "Lufubuchromis";

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
