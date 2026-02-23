using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Eugnathichthys;

/// <summary>
/// Abstract class for Eugnathichthys (genus).
/// NCBI TaxId: 1108581
/// </summary>
public abstract class Eugnathichthys : Distichodontidae, IEugnathichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eugnathichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1108581;

    /// <inheritdoc />
    public virtual string GenusName => "Eugnathichthys";

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
