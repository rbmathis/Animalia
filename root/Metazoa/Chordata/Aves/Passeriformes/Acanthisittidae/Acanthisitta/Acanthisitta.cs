using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthisittidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthisittidae.Acanthisitta;

/// <summary>
/// Abstract class for Acanthisitta (genus).
/// NCBI TaxId: 57067
/// </summary>
public abstract class Acanthisitta : Acanthisittidae, IAcanthisitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthisitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57067;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthisitta";

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
