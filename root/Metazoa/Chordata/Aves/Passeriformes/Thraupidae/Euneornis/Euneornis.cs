using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Euneornis;

/// <summary>
/// Abstract class for Euneornis (genus).
/// NCBI TaxId: 200193
/// </summary>
public abstract class Euneornis : Thraupidae, IEuneornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euneornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 200193;

    /// <inheritdoc />
    public virtual string GenusName => "Euneornis";

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
