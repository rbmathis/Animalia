using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Odontaspididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Odontaspididae.Odontaspis;

/// <summary>
/// Abstract class for Odontaspis (genus).
/// NCBI TaxId: 57988
/// </summary>
public abstract class Odontaspis : Odontaspididae, IOdontaspis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odontaspis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57988;

    /// <inheritdoc />
    public virtual string GenusName => "Odontaspis";

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
