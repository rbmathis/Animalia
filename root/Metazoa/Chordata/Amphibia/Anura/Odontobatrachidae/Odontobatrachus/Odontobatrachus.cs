using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Odontobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Odontobatrachidae.Odontobatrachus;

/// <summary>
/// Abstract class for Odontobatrachus (genus).
/// NCBI TaxId: 1481133
/// </summary>
public abstract class Odontobatrachus : Odontobatrachidae, IOdontobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odontobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1481133;

    /// <inheritdoc />
    public virtual string GenusName => "Odontobatrachus";

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
