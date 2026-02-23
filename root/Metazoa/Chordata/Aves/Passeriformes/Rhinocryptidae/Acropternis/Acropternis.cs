using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Acropternis;

/// <summary>
/// Abstract class for Acropternis (genus).
/// NCBI TaxId: 589932
/// </summary>
public abstract class Acropternis : Rhinocryptidae, IAcropternis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acropternis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 589932;

    /// <inheritdoc />
    public virtual string GenusName => "Acropternis";

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
