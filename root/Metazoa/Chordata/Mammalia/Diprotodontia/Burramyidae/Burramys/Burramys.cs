using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Burramyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Burramyidae.Burramys;

/// <summary>
/// Abstract class for Burramys (genus).
/// NCBI TaxId: 38599
/// </summary>
public abstract class Burramys : Burramyidae, IBurramys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Burramys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38599;

    /// <inheritdoc />
    public virtual string GenusName => "Burramys";

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
