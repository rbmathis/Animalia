using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Euristhmus;

/// <summary>
/// Abstract class for Euristhmus (genus).
/// NCBI TaxId: 2578377
/// </summary>
public abstract class Euristhmus : Plotosidae, IEuristhmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euristhmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578377;

    /// <inheritdoc />
    public virtual string GenusName => "Euristhmus";

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
