using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Craseomys;

/// <summary>
/// Abstract class for Craseomys (genus).
/// NCBI TaxId: 2929753
/// </summary>
public abstract class Craseomys : Cricetidae, ICraseomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Craseomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2929753;

    /// <inheritdoc />
    public virtual string GenusName => "Craseomys";

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
