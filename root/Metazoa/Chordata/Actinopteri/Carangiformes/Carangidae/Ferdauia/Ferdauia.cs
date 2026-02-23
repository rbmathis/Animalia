using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Ferdauia;

/// <summary>
/// Abstract class for Ferdauia (genus).
/// NCBI TaxId: 3040446
/// </summary>
public abstract class Ferdauia : Carangidae, IFerdauia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ferdauia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3040446;

    /// <inheritdoc />
    public virtual string GenusName => "Ferdauia";

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
