using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Paradactylodon;

/// <summary>
/// Abstract class for Paradactylodon (genus).
/// NCBI TaxId: 1008990
/// </summary>
public abstract class Paradactylodon : Hynobiidae, IParadactylodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paradactylodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1008990;

    /// <inheritdoc />
    public virtual string GenusName => "Paradactylodon";

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
