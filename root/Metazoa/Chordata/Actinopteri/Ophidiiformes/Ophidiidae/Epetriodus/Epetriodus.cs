using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Epetriodus;

/// <summary>
/// Abstract class for Epetriodus (genus).
/// NCBI TaxId: 3095262
/// </summary>
public abstract class Epetriodus : Ophidiidae, IEpetriodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epetriodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3095262;

    /// <inheritdoc />
    public virtual string GenusName => "Epetriodus";

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
