using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Mikrogeophagus;

/// <summary>
/// Abstract class for Mikrogeophagus (genus).
/// NCBI TaxId: 74128
/// </summary>
public abstract class Mikrogeophagus : Cichlidae, IMikrogeophagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mikrogeophagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74128;

    /// <inheritdoc />
    public virtual string GenusName => "Mikrogeophagus";

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
