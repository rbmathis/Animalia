using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Emberizoides;

/// <summary>
/// Abstract class for Emberizoides (genus).
/// NCBI TaxId: 221970
/// </summary>
public abstract class Emberizoides : Thraupidae, IEmberizoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Emberizoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221970;

    /// <inheritdoc />
    public virtual string GenusName => "Emberizoides";

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
