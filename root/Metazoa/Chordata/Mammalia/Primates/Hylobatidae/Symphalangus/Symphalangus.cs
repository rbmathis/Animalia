using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hylobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hylobatidae.Symphalangus;

/// <summary>
/// Abstract class for Symphalangus (genus).
/// NCBI TaxId: 325166
/// </summary>
public abstract class Symphalangus : Hylobatidae, ISymphalangus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Symphalangus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 325166;

    /// <inheritdoc />
    public virtual string GenusName => "Symphalangus";

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
