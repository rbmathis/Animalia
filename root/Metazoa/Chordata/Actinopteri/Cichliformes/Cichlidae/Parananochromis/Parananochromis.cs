using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Parananochromis;

/// <summary>
/// Abstract class for Parananochromis (genus).
/// NCBI TaxId: 1543267
/// </summary>
public abstract class Parananochromis : Cichlidae, IParananochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parananochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1543267;

    /// <inheritdoc />
    public virtual string GenusName => "Parananochromis";

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
