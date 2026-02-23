using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Castanozoster;

/// <summary>
/// Abstract class for Castanozoster (genus).
/// NCBI TaxId: 2692227
/// </summary>
public abstract class Castanozoster : Thraupidae, ICastanozoster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Castanozoster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2692227;

    /// <inheritdoc />
    public virtual string GenusName => "Castanozoster";

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
