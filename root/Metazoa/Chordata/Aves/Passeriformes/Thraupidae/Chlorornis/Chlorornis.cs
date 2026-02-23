using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Chlorornis;

/// <summary>
/// Abstract class for Chlorornis (genus).
/// NCBI TaxId: 62168
/// </summary>
public abstract class Chlorornis : Thraupidae, IChlorornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlorornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62168;

    /// <inheritdoc />
    public virtual string GenusName => "Chlorornis";

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
