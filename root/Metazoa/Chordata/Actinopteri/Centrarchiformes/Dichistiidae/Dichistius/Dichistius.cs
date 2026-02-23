using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Dichistiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Dichistiidae.Dichistius;

/// <summary>
/// Abstract class for Dichistius (genus).
/// NCBI TaxId: 390323
/// </summary>
public abstract class Dichistius : Dichistiidae, IDichistius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dichistius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390323;

    /// <inheritdoc />
    public virtual string GenusName => "Dichistius";

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
