using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Malindangia;

/// <summary>
/// Abstract class for Malindangia (genus).
/// NCBI TaxId: 3150781
/// </summary>
public abstract class Malindangia : Campephagidae, IMalindangia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malindangia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150781;

    /// <inheritdoc />
    public virtual string GenusName => "Malindangia";

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
