using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Archaeolemur;

/// <summary>
/// Abstract class for Archaeolemur (genus).
/// NCBI TaxId: 523820
/// </summary>
public abstract class Archaeolemur : Indriidae, IArchaeolemur
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Archaeolemur";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 523820;

    /// <inheritdoc />
    public virtual string GenusName => "Archaeolemur";

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
