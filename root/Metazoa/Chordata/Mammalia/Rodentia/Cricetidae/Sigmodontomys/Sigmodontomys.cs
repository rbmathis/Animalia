using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Sigmodontomys;

/// <summary>
/// Abstract class for Sigmodontomys (genus).
/// NCBI TaxId: 218837
/// </summary>
public abstract class Sigmodontomys : Cricetidae, ISigmodontomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sigmodontomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 218837;

    /// <inheritdoc />
    public virtual string GenusName => "Sigmodontomys";

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
