using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Elaphodus;

/// <summary>
/// Abstract class for Elaphodus (genus).
/// NCBI TaxId: 109297
/// </summary>
public abstract class Elaphodus : Cervidae, IElaphodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elaphodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109297;

    /// <inheritdoc />
    public virtual string GenusName => "Elaphodus";

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
